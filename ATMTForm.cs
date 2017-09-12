using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ATMT
{
    public partial class ATMTForm : Form
    {
        private bool isDrag = false, isFlow = false;
        private Point startPoint, sourcePoint;
        private Graphics canvasGraphics;
        private Element sourceElement;
        private ArrayList elementList;
        private AttackLibrary[][] attackLibraryList;
        private string fileName;
        private float zoomFactor;

        public DataTable currentDataTable { get; set; }

        public ATMTForm()
        {
            elementList = new ArrayList();
            InitializeComponent();
            zoomFactor = 1.0f;
            attackLibraryList = new AttackLibrary[25][];
            for(int idx=0; idx<attackLibraryList.Length; idx++)
            {
                attackLibraryList[idx] = new AttackLibrary[25];
            }
        }

        private void AtmtForm_Load(object sender, EventArgs e)
        {
            canvasGraphics = canvasPanel.CreateGraphics();
        }

        public void loadAttackLibrary()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string readLine;
            string fileName;
            ofd.Filter = "Attack Library List for ATMT File (*.alib)|*.alib";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;

                StreamReader sw = new StreamReader(ofd.FileName);

                // file read
                if ((readLine = sw.ReadLine()) != null)
                {
                    string[] firstParsedString = readLine.Split(',');

                    int sourceIndex = Int32.Parse(firstParsedString[1]);
                    int destinationIndex = Int32.Parse(firstParsedString[2]);
                    attackLibraryList[sourceIndex][destinationIndex] = new AttackLibrary();
                    attackLibraryList[sourceIndex][destinationIndex].type = firstParsedString[3];
                    attackLibraryList[sourceIndex][destinationIndex].description = firstParsedString[4];
                    attackLibraryList[sourceIndex][destinationIndex].attackMethod = firstParsedString[5];
                    attackLibraryList[sourceIndex][destinationIndex].recommendation = firstParsedString[5];
                    attackLibraryList[sourceIndex][destinationIndex].caption =
                    atmtOriginalImageList.Images.Keys[sourceIndex].Replace(".png", "") + " -> "
                        + atmtOriginalImageList.Images.Keys[destinationIndex].Replace(".png", "");
                }

                sw.Close();
            }
        }

        private void DrawGraphPanel()
        {
            int i;
            for (i = 0; i < canvasPanel.Width; i += 10)
            {
                canvasGraphics.DrawLine(Pens.White, i, 0, i, canvasPanel.Height);
            }
            for (i = 0; i < canvasPanel.Width; i += 10)
            {
                canvasGraphics.DrawLine(Pens.White, 0, i, canvasPanel.Width, i);
            }
        }

        private void DrawElement()
        {
            Pen thickPen = new Pen(Color.Black, 3);
            Pen dashPen  = new Pen(Color.Black, 3);
            dashPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };

            foreach (Element currentElement in elementList)
            {
                PictureBox currentPictureBox = currentElement.getPictureBox();
                foreach(Element referElement in currentElement.getInternalElementList())
                {
                    PictureBox referPictureBox = referElement.getPictureBox();
                    canvasGraphics.DrawLine(thickPen,
                        currentPictureBox.Left + (currentPictureBox.Width  >> 1),
                        currentPictureBox.Top  + (currentPictureBox.Height >> 1),
                        referPictureBox.Left   + (referPictureBox.Width    >> 1),
                        referPictureBox.Top    + (referPictureBox.Height   >> 1));
                }

                foreach (Element referElement in currentElement.getExternalElementList())
                {
                    PictureBox referPictureBox = referElement.getPictureBox();
                    canvasGraphics.DrawLine(dashPen,
                        currentPictureBox.Left + (currentPictureBox.Width >> 1),
                        currentPictureBox.Top + (currentPictureBox.Height >> 1),
                        referPictureBox.Left + (referPictureBox.Width >> 1),
                        referPictureBox.Top + (referPictureBox.Height >> 1));
                }
            }
            Invalidate();
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            canvasGraphics.Clear(Color.FromArgb(0x99, 0xB4, 0xD1));
            //DrawGraphPanel();
            DrawElement();
        }

        private void AtmtTree_MouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (!currentNode.Text.Equals("Bus") && !currentNode.Text.Equals("Module") && !currentNode.Text.Equals("Communication")
                 && !currentNode.Text.Equals("System") && !currentNode.Text.Equals("Sensor")
                 && !currentNode.Text.Equals("InternalDataFlow") && !currentNode.Text.Equals("ExternalDataFlow"))
            {
                Element element = new Element();
                element.setType(currentNode.ImageIndex);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = atmtOriginalImageList.Images[element.getType()];
                pictureBox.Size = new Size(75, 75);
                pictureBox.MouseDown += new MouseEventHandler(this.PictureBox_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(this.PictureBox_MouseMove);
                pictureBox.MouseUp   += new MouseEventHandler(this.PictureBox_MouseUp);
                canvasPanel.Controls.Add(pictureBox);
                element.setPictureBox(pictureBox);
                elementList.Add(element);
                pictureBox.Select();
            }
        }

        public Element findElement(PictureBox pictureBox)
        {
            Element resultElement = null;

            foreach (Element currentElement in elementList)
            {
                if (pictureBox == currentElement.getPictureBox())
                {
                    resultElement = currentElement;
                }
            }

            return resultElement;
        }

        public Element findElement(int elementId)
        {
            Element resultElement = null;

            foreach (Element currentElement in elementList)
            {
                if (elementId == currentElement.getId())
                {
                    resultElement = currentElement;
                }
            }

            return resultElement;
        }

        public void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            if(e.Button == MouseButtons.Left) {
                startPoint = e.Location;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Automotive Threat Modeling Tool File (*.atmt)|*.atmt";
            if (fileName == null && sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
            }

            if(fileName.Length > 0)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                // file write
                sw.Write("BE"); // Base Element

                foreach (Element currentElement in elementList)
                {
                    PictureBox currentPictureBox = currentElement.getPictureBox();
                    sw.Write(' ');
                    sw.Write(currentElement.getType());
                    sw.Write(',');
                    sw.Write(currentPictureBox.Left);
                    sw.Write(',');
                    sw.Write(currentPictureBox.Top);
                    sw.Write(',');
                    sw.Write(currentPictureBox.Width);
                    sw.Write(',');
                    sw.Write(currentPictureBox.Height);
                }

                sw.WriteLine();

                // Reference Element
                foreach (Element currentElement in elementList)
                {
                    sw.Write(currentElement.getId());

                    sw.Write(" IE"); // Internal Reference Element

                    foreach (Element referElement in currentElement.getInternalElementList())
                    {
                        PictureBox referPictureBox = referElement.getPictureBox();
                        sw.Write(',');
                        sw.Write(referElement.getId());
                    }

                    sw.Write(" EE"); // External Reference Element

                    foreach (Element referElement in currentElement.getExternalElementList())
                    {
                        PictureBox referPictureBox = referElement.getPictureBox();
                        sw.Write(',');
                        sw.Write(referElement.getId());
                    }

                    sw.WriteLine();
                }

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string readLine;
            ofd.Filter = "Automotive Threat Modeling Tool File (*.atmt)|*.atmt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                elementList.Clear();
                canvasPanel.Controls.Clear();
                Element.clearElementId();
                fileName = ofd.FileName;

                StreamReader sw = new StreamReader(ofd.FileName);

                // file read
                if((readLine = sw.ReadLine()) != null)
                {
                    string[] firstParsedString = readLine.Split(' ');
                    if(!"BE".Equals(firstParsedString[0]))
                    {
                        throw new Exception("파일 형식이 다릅니다.");
                    }

                    for(int idx=1; idx<firstParsedString.Length; idx++)
                    {
                        string[] secondParsedString = firstParsedString[idx].Split(',');
                        Element newElement = new Element();
                        newElement.setType(Int32.Parse(secondParsedString[0]));
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = atmtOriginalImageList.Images[newElement.getType()];
                        pictureBox.MouseDown += new MouseEventHandler(this.PictureBox_MouseDown);
                        pictureBox.MouseMove += new MouseEventHandler(this.PictureBox_MouseMove);
                        pictureBox.MouseUp += new MouseEventHandler(this.PictureBox_MouseUp);
                        pictureBox.Left   = Int32.Parse(secondParsedString[1]);
                        pictureBox.Top    = Int32.Parse(secondParsedString[2]);
                        pictureBox.Width  = Int32.Parse(secondParsedString[3]);
                        pictureBox.Height = Int32.Parse(secondParsedString[4]);

                        canvasPanel.Controls.Add(pictureBox);
                        newElement.setPictureBox(pictureBox);
                        elementList.Add(newElement);
                    }
                }

                while ((readLine = sw.ReadLine()) != null && readLine.Length > 0)
                {
                    string[] firstParsedString = readLine.Split(' ');
                    Element referElement = findElement(Int32.Parse(firstParsedString[0]));

                    // internal element
                    string[] secondParsedString = firstParsedString[1].Split(',');
                    for(int secondIdx=1; secondIdx < secondParsedString.Length; secondIdx++)
                    {
                        referElement.addInternalElementList(findElement(Int32.Parse(secondParsedString[secondIdx])));
                    }

                    // external element
                    secondParsedString = firstParsedString[2].Split(',');
                    for (int secondIdx = 1; secondIdx < secondParsedString.Length; secondIdx++)
                    {
                        referElement.addExternalElementList(findElement(Int32.Parse(secondParsedString[secondIdx])));
                    }

                }

                sw.Close();
            }
        }

        private void newModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elementList.Clear();
            canvasPanel.Controls.Clear();
            Element.clearElementId();
            fileName = null;
        }

        private void closeModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elementList.Clear();
            canvasPanel.Controls.Clear();
            Element.clearElementId();
            fileName = null;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Automotive Threat Modeling Tool File (*.atmt)|*.atmt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.25f;
            canvasGraphics.ScaleTransform(zoomFactor, zoomFactor);
            canvasPanel.Invalidate();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomFactor -= 0.25f;
            canvasGraphics.ScaleTransform(zoomFactor, zoomFactor);
            canvasPanel.Invalidate();
        }

        private void editAttackLibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loadAttackLibrary();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();
            dataTable.Columns.Add();

            for (int rowIdx = 0; rowIdx < attackLibraryList.Length; rowIdx++)
            {
                for (int colIdx = 0; colIdx < attackLibraryList[rowIdx].Length; colIdx++)
                {
                    if(attackLibraryList[rowIdx][colIdx] != null)
                    {
                        DataRow currentRow = dataTable.NewRow();
                        currentRow[0] = rowIdx;
                        currentRow[1] = colIdx;
                        currentRow[2] = attackLibraryList[rowIdx][colIdx].type;
                        currentRow[3] = attackLibraryList[rowIdx][colIdx].description;
                        currentRow[4] = attackLibraryList[rowIdx][colIdx].attackMethod;
                        currentRow[5] = attackLibraryList[rowIdx][colIdx].recommendation;
                        dataTable.Rows.Add(currentRow);
                    }
                }
            }

            AttackLibraryManager attackLibraryManager = new AttackLibraryManager(dataTable);
            DialogResult result = attackLibraryManager.ShowDialog();
            if(result == DialogResult.OK)
            {
                for (int idx = 0; idx < attackLibraryList.Length; idx++)
                {
                    attackLibraryList[idx] = new AttackLibrary[25];
                }

                dataTable = attackLibraryManager.dataTable;
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    string[] dataArray = dataRow.ItemArray.Cast<string>().ToArray();
                    int sourceIndex = Int32.Parse(dataArray[0]);
                    int destinationIndex = Int32.Parse(dataArray[1]);
                    attackLibraryList[sourceIndex][destinationIndex] = new AttackLibrary();
                    attackLibraryList[sourceIndex][destinationIndex].type = dataArray[2];
                    attackLibraryList[sourceIndex][destinationIndex].description = dataArray[3];
                    attackLibraryList[sourceIndex][destinationIndex].attackMethod = dataArray[4];
                    attackLibraryList[sourceIndex][destinationIndex].recommendation = dataArray[5];
                    attackLibraryList[sourceIndex][destinationIndex].caption =
                    atmtOriginalImageList.Images.Keys[sourceIndex].Replace(".png", "") + " -> "
                        + atmtOriginalImageList.Images.Keys[destinationIndex].Replace(".png", "");

                }
            }
        }

        private void sANELabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://KimLab.net");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMTAbout atmtAbout = new ATMTAbout();
            atmtAbout.ShowDialog();
        }

        public void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrag)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Element currentElement = findElement(sender as PictureBox);
                    PictureBox pictureBox = currentElement.getPictureBox();
                    pictureBox.Top += e.Y - startPoint.Y;
                    pictureBox.Left += e.X - startPoint.X;
                }
            }
        }

        public void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
            Control control = sender as Control;

            if (atmtTree.SelectedNode != null && atmtTree.SelectedNode.Text.Equals("InternalDataFlow"))
            {
                if (isFlow)
                {
                    Element destinationElement = findElement(sender as PictureBox);
                    sourceElement.addInternalElementList(destinationElement);
                    destinationElement.addInternalElementList(sourceElement);
                    sourceElement = null;
                    isFlow = false;
                }
                else
                {
                    sourceElement = findElement(sender as PictureBox);
                    sourcePoint.X = control.Left + (control.Width >> 1);
                    sourcePoint.Y = control.Top + (control.Height >> 1);
                    isFlow = true;
                }
            }
            else if (atmtTree.SelectedNode != null && atmtTree.SelectedNode.Text.Equals("ExternalDataFlow"))
            {
                if (isFlow)
                {
                    Element destinationElement = findElement(sender as PictureBox);
                    sourceElement.addExternalElementList(destinationElement);
                    destinationElement.addExternalElementList(sourceElement);
                    sourceElement = null;
                    isFlow = false;
                }
                else
                {
                    sourceElement = findElement(sender as PictureBox);
                    sourcePoint.X = control.Left + (control.Width >> 1);
                    sourcePoint.Y = control.Top + (control.Height >> 1);
                    isFlow = true;
                }
            } else
            {
                atmtPropertyGrid.SelectedObject = null;
                ElementProperty elementProperty = new ElementProperty();
                List<AttackLibrary> propertyList = new List<AttackLibrary>();

                Element selectedElement = findElement(sender as PictureBox);

                foreach (Element currentElement in selectedElement.getInternalElementList()) {
                    AttackLibrary attackLibrary = attackLibraryList[selectedElement.getType()][currentElement.getType()];
                    if (attackLibrary != null)
                    {
                        propertyList.Add(attackLibrary);
                    }
                    // bi-direction
                    attackLibrary = attackLibraryList[currentElement.getType()][selectedElement.getType()];
                    if (attackLibrary != null)
                    {
                        propertyList.Add(attackLibrary);
                    }
                }
                foreach (Element currentElement in selectedElement.getExternalElementList())
                {
                    AttackLibrary attackLibrary = attackLibraryList[selectedElement.getType()][currentElement.getType()];
                    if (attackLibrary != null)
                    {
                        propertyList.Add(attackLibrary);
                    }
                    // bi-direction
                    attackLibrary = attackLibraryList[currentElement.getType()][selectedElement.getType()];
                    if (attackLibrary != null)
                    {
                        propertyList.Add(attackLibrary);
                    }
                }

                elementProperty.attackLibraryList = propertyList.ToArray();
                atmtPropertyGrid.SelectedObject = elementProperty;
                atmtPropertyGrid.ExpandAllGridItems();
            }
        }
    }
}
