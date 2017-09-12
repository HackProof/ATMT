namespace ATMT
{
    partial class ATMTForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("FlexRay", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CAN", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("LIN", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("MOST", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bus", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ECU", 6, 6);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Module", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bluetooth", 8, 8);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Radio", 9, 9);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Wifi", 10, 10);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("3G/4G/5G", 11, 11);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("USB", 12, 12);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("OBD/OBU", 13, 13);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("GPS", 14, 14);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Communication", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Braking System", 16, 16);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Engine System", 17, 17);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Steering System", 18, 18);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("System", 15, 15, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tire Pressure", 20, 20);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Light", 21, 21);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Temperature", 22, 22);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Sensor", 19, 19, new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("InternalDataFlow", 23, 23);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("ExternalDataFlow", 24, 24);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMTForm));
            this.atmtMenuStrip = new System.Windows.Forms.MenuStrip();
            this.atmtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTMTInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAttackLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sANELabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atmtTree = new System.Windows.Forms.TreeView();
            this.atmtImageList = new System.Windows.Forms.ImageList(this.components);
            this.atmtPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.atmtOriginalImageList = new System.Windows.Forms.ImageList(this.components);
            this.canvasPanel = new ATMT.DoubleCanvas();
            this.atmtMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // atmtMenuStrip
            // 
            this.atmtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atmtMenu,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.attackLibToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.atmtMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.atmtMenuStrip.Name = "atmtMenuStrip";
            this.atmtMenuStrip.Size = new System.Drawing.Size(1584, 24);
            this.atmtMenuStrip.TabIndex = 0;
            this.atmtMenuStrip.Text = "atmtMenuStrip";
            // 
            // atmtMenu
            // 
            this.atmtMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModelToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.aTMTInformationToolStripMenuItem,
            this.closeModelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.atmtMenu.Name = "atmtMenu";
            this.atmtMenu.Size = new System.Drawing.Size(37, 20);
            this.atmtMenu.Text = "&File";
            // 
            // newModelToolStripMenuItem
            // 
            this.newModelToolStripMenuItem.Name = "newModelToolStripMenuItem";
            this.newModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newModelToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newModelToolStripMenuItem.Text = "New Model(&N)";
            this.newModelToolStripMenuItem.Click += new System.EventHandler(this.newModelToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openToolStripMenuItem.Text = "Open(&O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...(&A)";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // aTMTInformationToolStripMenuItem
            // 
            this.aTMTInformationToolStripMenuItem.Name = "aTMTInformationToolStripMenuItem";
            this.aTMTInformationToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aTMTInformationToolStripMenuItem.Text = "ATMT Information";
            // 
            // closeModelToolStripMenuItem
            // 
            this.closeModelToolStripMenuItem.Name = "closeModelToolStripMenuItem";
            this.closeModelToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.closeModelToolStripMenuItem.Text = "Close Model(&C)";
            this.closeModelToolStripMenuItem.Click += new System.EventHandler(this.closeModelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Enabled = false;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.ShowShortcutKeys = false;
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Enabled = false;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.ShowShortcutKeys = false;
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.helpToolStripMenuItem.Text = "Reports";
            // 
            // attackLibToolStripMenuItem
            // 
            this.attackLibToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAttackLibToolStripMenuItem});
            this.attackLibToolStripMenuItem.Name = "attackLibToolStripMenuItem";
            this.attackLibToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.attackLibToolStripMenuItem.Text = "Attack Lib";
            // 
            // editAttackLibToolStripMenuItem
            // 
            this.editAttackLibToolStripMenuItem.Name = "editAttackLibToolStripMenuItem";
            this.editAttackLibToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editAttackLibToolStripMenuItem.Text = "Edit Attack Lib";
            this.editAttackLibToolStripMenuItem.Click += new System.EventHandler(this.editAttackLibToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sANELabToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // sANELabToolStripMenuItem
            // 
            this.sANELabToolStripMenuItem.Name = "sANELabToolStripMenuItem";
            this.sANELabToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sANELabToolStripMenuItem.Text = "SANE Lab";
            this.sANELabToolStripMenuItem.Click += new System.EventHandler(this.sANELabToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // atmtTree
            // 
            this.atmtTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.atmtTree.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmtTree.ImageKey = "FlexRay.png";
            this.atmtTree.ImageList = this.atmtImageList;
            this.atmtTree.Location = new System.Drawing.Point(0, 24);
            this.atmtTree.Name = "atmtTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "flexRayNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "FlexRay";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "canNode";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "CAN";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "linNode";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "LIN";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "mostNode";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "MOST";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "busNode";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Bus";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "ecuNode";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "ECU";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "moduleNode";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "Module";
            treeNode8.ImageIndex = 8;
            treeNode8.Name = "bluetoothNode";
            treeNode8.SelectedImageIndex = 8;
            treeNode8.Text = "Bluetooth";
            treeNode9.ImageIndex = 9;
            treeNode9.Name = "radioNode";
            treeNode9.SelectedImageIndex = 9;
            treeNode9.Text = "Radio";
            treeNode10.ImageIndex = 10;
            treeNode10.Name = "wifiNode";
            treeNode10.SelectedImageIndex = 10;
            treeNode10.Text = "Wifi";
            treeNode11.ImageIndex = 11;
            treeNode11.Name = "cellularNode";
            treeNode11.SelectedImageIndex = 11;
            treeNode11.Text = "3G/4G/5G";
            treeNode12.ImageIndex = 12;
            treeNode12.Name = "usbNode";
            treeNode12.SelectedImageIndex = 12;
            treeNode12.Text = "USB";
            treeNode13.ImageIndex = 13;
            treeNode13.Name = "obdNode";
            treeNode13.SelectedImageIndex = 13;
            treeNode13.Text = "OBD/OBU";
            treeNode14.ImageIndex = 14;
            treeNode14.Name = "gpsNode";
            treeNode14.SelectedImageIndex = 14;
            treeNode14.Text = "GPS";
            treeNode15.ImageIndex = 7;
            treeNode15.Name = "communicationNode";
            treeNode15.SelectedImageIndex = 7;
            treeNode15.Text = "Communication";
            treeNode16.ImageIndex = 16;
            treeNode16.Name = "brakingNode";
            treeNode16.SelectedImageIndex = 16;
            treeNode16.Text = "Braking System";
            treeNode17.ImageIndex = 17;
            treeNode17.Name = "engineNode";
            treeNode17.SelectedImageIndex = 17;
            treeNode17.Text = "Engine System";
            treeNode18.ImageIndex = 18;
            treeNode18.Name = "steeringNode";
            treeNode18.SelectedImageIndex = 18;
            treeNode18.Text = "Steering System";
            treeNode19.ImageIndex = 15;
            treeNode19.Name = "systemNode";
            treeNode19.SelectedImageIndex = 15;
            treeNode19.Text = "System";
            treeNode20.ImageIndex = 20;
            treeNode20.Name = "tireNode";
            treeNode20.SelectedImageIndex = 20;
            treeNode20.Text = "Tire Pressure";
            treeNode21.ImageIndex = 21;
            treeNode21.Name = "lightNode";
            treeNode21.SelectedImageIndex = 21;
            treeNode21.Text = "Light";
            treeNode22.ImageIndex = 22;
            treeNode22.Name = "temperatureNode";
            treeNode22.SelectedImageIndex = 22;
            treeNode22.Text = "Temperature";
            treeNode23.ImageIndex = 19;
            treeNode23.Name = "sensorNode";
            treeNode23.SelectedImageIndex = 19;
            treeNode23.Text = "Sensor";
            treeNode24.ImageIndex = 23;
            treeNode24.Name = "internalDataFlow";
            treeNode24.SelectedImageIndex = 23;
            treeNode24.Text = "InternalDataFlow";
            treeNode25.ImageIndex = 24;
            treeNode25.Name = "externalDataFlow";
            treeNode25.SelectedImageIndex = 24;
            treeNode25.Text = "ExternalDataFlow";
            this.atmtTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode15,
            treeNode19,
            treeNode23,
            treeNode24,
            treeNode25});
            this.atmtTree.SelectedImageKey = "FlexRay.png";
            this.atmtTree.Size = new System.Drawing.Size(219, 837);
            this.atmtTree.TabIndex = 8;
            this.atmtTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AtmtTree_MouseDoubleClick);
            // 
            // atmtImageList
            // 
            this.atmtImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("atmtImageList.ImageStream")));
            this.atmtImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.atmtImageList.Images.SetKeyName(0, "Bus.png");
            this.atmtImageList.Images.SetKeyName(1, "FlexRay.png");
            this.atmtImageList.Images.SetKeyName(2, "CAN.png");
            this.atmtImageList.Images.SetKeyName(3, "LIN.png");
            this.atmtImageList.Images.SetKeyName(4, "MOST.png");
            this.atmtImageList.Images.SetKeyName(5, "Module.png");
            this.atmtImageList.Images.SetKeyName(6, "ECU.png");
            this.atmtImageList.Images.SetKeyName(7, "Communication.png");
            this.atmtImageList.Images.SetKeyName(8, "Bluetooth.png");
            this.atmtImageList.Images.SetKeyName(9, "Radio.png");
            this.atmtImageList.Images.SetKeyName(10, "Wifi.png");
            this.atmtImageList.Images.SetKeyName(11, "Cellular.png");
            this.atmtImageList.Images.SetKeyName(12, "USB.png");
            this.atmtImageList.Images.SetKeyName(13, "OBD.png");
            this.atmtImageList.Images.SetKeyName(14, "GPS.png");
            this.atmtImageList.Images.SetKeyName(15, "System.png");
            this.atmtImageList.Images.SetKeyName(16, "Braking.png");
            this.atmtImageList.Images.SetKeyName(17, "Engine.png");
            this.atmtImageList.Images.SetKeyName(18, "Steering.png");
            this.atmtImageList.Images.SetKeyName(19, "Sensor.png");
            this.atmtImageList.Images.SetKeyName(20, "Tire.png");
            this.atmtImageList.Images.SetKeyName(21, "Light.png");
            this.atmtImageList.Images.SetKeyName(22, "Temperature.png");
            this.atmtImageList.Images.SetKeyName(23, "InternalDataFlow.png");
            this.atmtImageList.Images.SetKeyName(24, "ExternalDataFlow.png");
            // 
            // atmtPropertyGrid
            // 
            this.atmtPropertyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.atmtPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.atmtPropertyGrid.Location = new System.Drawing.Point(219, 637);
            this.atmtPropertyGrid.Name = "atmtPropertyGrid";
            this.atmtPropertyGrid.Size = new System.Drawing.Size(1365, 224);
            this.atmtPropertyGrid.TabIndex = 9;
            // 
            // atmtOriginalImageList
            // 
            this.atmtOriginalImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("atmtOriginalImageList.ImageStream")));
            this.atmtOriginalImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.atmtOriginalImageList.Images.SetKeyName(0, "Bus.png");
            this.atmtOriginalImageList.Images.SetKeyName(1, "FlexRay.png");
            this.atmtOriginalImageList.Images.SetKeyName(2, "CAN.png");
            this.atmtOriginalImageList.Images.SetKeyName(3, "LIN.png");
            this.atmtOriginalImageList.Images.SetKeyName(4, "MOST.png");
            this.atmtOriginalImageList.Images.SetKeyName(5, "Module.png");
            this.atmtOriginalImageList.Images.SetKeyName(6, "ECU.png");
            this.atmtOriginalImageList.Images.SetKeyName(7, "Communication.png");
            this.atmtOriginalImageList.Images.SetKeyName(8, "Bluetooth.png");
            this.atmtOriginalImageList.Images.SetKeyName(9, "Radio.png");
            this.atmtOriginalImageList.Images.SetKeyName(10, "Wifi.png");
            this.atmtOriginalImageList.Images.SetKeyName(11, "Cellular.png");
            this.atmtOriginalImageList.Images.SetKeyName(12, "USB.png");
            this.atmtOriginalImageList.Images.SetKeyName(13, "OBD.png");
            this.atmtOriginalImageList.Images.SetKeyName(14, "GPS.png");
            this.atmtOriginalImageList.Images.SetKeyName(15, "System.png");
            this.atmtOriginalImageList.Images.SetKeyName(16, "Braking.png");
            this.atmtOriginalImageList.Images.SetKeyName(17, "Engine.png");
            this.atmtOriginalImageList.Images.SetKeyName(18, "Steering.png");
            this.atmtOriginalImageList.Images.SetKeyName(19, "Sensor.png");
            this.atmtOriginalImageList.Images.SetKeyName(20, "Tire.png");
            this.atmtOriginalImageList.Images.SetKeyName(21, "Light.png");
            this.atmtOriginalImageList.Images.SetKeyName(22, "Temperature.png");
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(219, 24);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1365, 613);
            this.canvasPanel.TabIndex = 10;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            // 
            // ATMTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.atmtPropertyGrid);
            this.Controls.Add(this.atmtTree);
            this.Controls.Add(this.atmtMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.atmtMenuStrip;
            this.Name = "ATMTForm";
            this.Text = "Threat Modeling Tool for Vehicle";
            this.Load += new System.EventHandler(this.AtmtForm_Load);
            this.atmtMenuStrip.ResumeLayout(false);
            this.atmtMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip atmtMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem atmtMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TreeView atmtTree;
        private System.Windows.Forms.PropertyGrid atmtPropertyGrid;
        private DoubleCanvas canvasPanel;
        private System.Windows.Forms.ImageList atmtImageList;
        private System.Windows.Forms.ImageList atmtOriginalImageList;
        private System.Windows.Forms.ToolStripMenuItem newModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTMTInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sANELabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAttackLibToolStripMenuItem;
    }
}

