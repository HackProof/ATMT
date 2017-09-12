using System;
using System.Data;
using System.Windows.Forms;

namespace ATMT
{
    public class AttackLibraryManager : Form
    {
        private DataGridView dataGridView;
        private Button saveButton;
        private Button buttonOK;
        private DataGridViewTextBoxColumn Source;
        private DataGridViewTextBoxColumn Target;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn ThreatDescription;
        private DataGridViewTextBoxColumn AttackMethod;
        private DataGridViewTextBoxColumn Recommendation;
        private Button loadButton;

        public DataTable dataTable { get; set; }

        public AttackLibraryManager(DataTable dataTable)
        {
            InitializeComponent();
            dataGridView.Rows.Clear();
            foreach (DataRow currentRow in dataTable.Rows)
            {
                dataGridView.Rows.Add(currentRow.ItemArray);
            }
        }

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreatDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttackMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recommendation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Target,
            this.Type,
            this.ThreatDescription,
            this.AttackMethod,
            this.Recommendation});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1046, 350);
            this.dataGridView.TabIndex = 0;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // ThreatDescription
            // 
            this.ThreatDescription.FillWeight = 200F;
            this.ThreatDescription.HeaderText = "ThreatDescription";
            this.ThreatDescription.Name = "ThreatDescription";
            // 
            // AttackMethod
            // 
            this.AttackMethod.FillWeight = 300F;
            this.AttackMethod.HeaderText = "AttackMethod";
            this.AttackMethod.Name = "AttackMethod";
            // 
            // Recommendation
            // 
            this.Recommendation.FillWeight = 200F;
            this.Recommendation.HeaderText = "Recommendation";
            this.Recommendation.Name = "Recommendation";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(799, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(880, 356);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(961, 356);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AttackLibraryManager
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 386);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "AttackLibraryManager";
            this.Text = "Attack Library Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Attack Library List for ATMT File (*.alib)|*.alib";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                DataSet dataSet = new DataSet("ATMT");
                DataTable dataTable = new DataTable("row");

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }
                
                foreach(DataGridViewRow row in dataGridView.Rows)
                {
                    if(row.Cells[0].Value == null)
                    {
                        break;
                    }

                    DataRow currentRow = dataTable.NewRow();
                    for(int i=0; i<dataGridView.ColumnCount; i++)
                    {
                        currentRow[i] = row.Cells[i].Value;
                    }
                    dataTable.Rows.Add(currentRow);
                }

                dataSet.Tables.Add(dataTable);
                dataSet.WriteXml(sfd.FileName);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Attack Library List for ATMT File (*.alib)|*.alib";
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(ofd.FileName);
                DataTable dataTable = dataSet.Tables[0];
                dataGridView.Rows.Clear();
                foreach(DataRow currentRow in dataTable.Rows)
                {
                    dataGridView.Rows.Add(currentRow.ItemArray);
                }
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.dataTable = new DataTable("row");

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    break;
                }

                DataRow currentRow = this.dataTable.NewRow();
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    currentRow[i] = row.Cells[i].Value;
                }
                this.dataTable.Rows.Add(currentRow);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}