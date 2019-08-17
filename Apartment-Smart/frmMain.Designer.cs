namespace ApartmentSmart
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.radialMenuItem1 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem2 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem3 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem4 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem5 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem6 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem7 = new DevComponents.DotNetBar.RadialMenuItem();
            this.rbMenu = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbaReport = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbaTenant = new DevComponents.DotNetBar.RibbonBar();
            this.rbtTenant = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbaRoom = new DevComponents.DotNetBar.RibbonBar();
            this.rbtProduct = new DevComponents.DotNetBar.ButtonItem();
            this.rbtOrder = new DevComponents.DotNetBar.ButtonItem();
            this.rbtReceiver = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbaSetup = new DevComponents.DotNetBar.RibbonBar();
            this.rbtOrg = new DevComponents.DotNetBar.ButtonItem();
            this.rttFiles = new DevComponents.DotNetBar.RibbonTabItem();
            this.rttRoom = new DevComponents.DotNetBar.RibbonTabItem();
            this.rttTenant = new DevComponents.DotNetBar.RibbonTabItem();
            this.rttReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.rbtSetup_Exit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.rbMenu.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radialMenu1
            // 
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.radialMenuItem1,
            this.radialMenuItem2,
            this.radialMenuItem3,
            this.radialMenuItem4,
            this.radialMenuItem5,
            this.radialMenuItem6,
            this.radialMenuItem7});
            this.radialMenu1.Location = new System.Drawing.Point(6, 3);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 13F;
            this.radialMenu1.TabIndex = 0;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // radialMenuItem1
            // 
            this.radialMenuItem1.Name = "radialMenuItem1";
            this.radialMenuItem1.Text = "Item 1";
            // 
            // radialMenuItem2
            // 
            this.radialMenuItem2.Name = "radialMenuItem2";
            this.radialMenuItem2.Text = "Item 2";
            // 
            // radialMenuItem3
            // 
            this.radialMenuItem3.Name = "radialMenuItem3";
            this.radialMenuItem3.Text = "Item 3";
            // 
            // radialMenuItem4
            // 
            this.radialMenuItem4.Name = "radialMenuItem4";
            this.radialMenuItem4.Text = "Item 4";
            // 
            // radialMenuItem5
            // 
            this.radialMenuItem5.Name = "radialMenuItem5";
            this.radialMenuItem5.Text = "Item 5";
            // 
            // radialMenuItem6
            // 
            this.radialMenuItem6.Name = "radialMenuItem6";
            this.radialMenuItem6.Text = "Item 6";
            // 
            // radialMenuItem7
            // 
            this.radialMenuItem7.Name = "radialMenuItem7";
            this.radialMenuItem7.Text = "Item 7";
            // 
            // rbMenu
            // 
            this.rbMenu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rbMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbMenu.Controls.Add(this.ribbonPanel2);
            this.rbMenu.Controls.Add(this.ribbonPanel1);
            this.rbMenu.Controls.Add(this.ribbonPanel3);
            this.rbMenu.Controls.Add(this.ribbonPanel4);
            this.rbMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbMenu.ForeColor = System.Drawing.Color.Black;
            this.rbMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rttFiles,
            this.rttRoom,
            this.rttTenant,
            this.rttReport});
            this.rbMenu.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rbMenu.Location = new System.Drawing.Point(0, 0);
            this.rbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.rbMenu.Name = "rbMenu";
            this.rbMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rbMenu.Size = new System.Drawing.Size(798, 94);
            this.rbMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbMenu.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rbMenu.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rbMenu.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rbMenu.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rbMenu.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rbMenu.SystemText.QatDialogAddButton = "&Add >>";
            this.rbMenu.SystemText.QatDialogCancelButton = "Cancel";
            this.rbMenu.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rbMenu.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rbMenu.SystemText.QatDialogOkButton = "OK";
            this.rbMenu.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rbMenu.SystemText.QatDialogRemoveButton = "&Remove";
            this.rbMenu.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rbMenu.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rbMenu.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rbMenu.TabGroupHeight = 14;
            this.rbMenu.TabIndex = 3;
            this.rbMenu.Text = "rbHome";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.rbaReport);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 27);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(798, 64);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // rbaReport
            // 
            this.rbaReport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbaReport.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaReport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbaReport.ContainerControlProcessDialogKey = true;
            this.rbaReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbaReport.DragDropSupport = true;
            this.rbaReport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4});
            this.rbaReport.Location = new System.Drawing.Point(3, 0);
            this.rbaReport.Name = "rbaReport";
            this.rbaReport.Size = new System.Drawing.Size(792, 61);
            this.rbaReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbaReport.TabIndex = 0;
            this.rbaReport.Text = "รายงาน";
            // 
            // 
            // 
            this.rbaReport.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaReport.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "buttonItem4";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.rbaTenant);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 27);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(798, 64);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // rbaTenant
            // 
            this.rbaTenant.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbaTenant.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaTenant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbaTenant.ContainerControlProcessDialogKey = true;
            this.rbaTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbaTenant.DragDropSupport = true;
            this.rbaTenant.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtTenant,
            this.buttonItem5});
            this.rbaTenant.Location = new System.Drawing.Point(3, 0);
            this.rbaTenant.Name = "rbaTenant";
            this.rbaTenant.Size = new System.Drawing.Size(792, 61);
            this.rbaTenant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbaTenant.TabIndex = 0;
            this.rbaTenant.Text = "Tenant";
            // 
            // 
            // 
            this.rbaTenant.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaTenant.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbtTenant
            // 
            this.rbtTenant.Name = "rbtTenant";
            this.rbtTenant.SubItemsExpandWidth = 14;
            this.rbtTenant.Text = "ข้อมูลผู้เช่า";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.rbaRoom);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 27);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(798, 64);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // rbaRoom
            // 
            this.rbaRoom.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbaRoom.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaRoom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbaRoom.ContainerControlProcessDialogKey = true;
            this.rbaRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbaRoom.DragDropSupport = true;
            this.rbaRoom.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtProduct,
            this.rbtOrder,
            this.rbtReceiver});
            this.rbaRoom.Location = new System.Drawing.Point(3, 0);
            this.rbaRoom.Name = "rbaRoom";
            this.rbaRoom.Size = new System.Drawing.Size(792, 61);
            this.rbaRoom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbaRoom.TabIndex = 0;
            this.rbaRoom.Text = "Room";
            // 
            // 
            // 
            this.rbaRoom.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaRoom.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbtProduct
            // 
            this.rbtProduct.Name = "rbtProduct";
            this.rbtProduct.SubItemsExpandWidth = 14;
            this.rbtProduct.Text = "ข้อมูลห้องพัก";
            // 
            // rbtOrder
            // 
            this.rbtOrder.Name = "rbtOrder";
            this.rbtOrder.SubItemsExpandWidth = 14;
            this.rbtOrder.Text = "ข้อมูล";
            // 
            // rbtReceiver
            // 
            this.rbtReceiver.Name = "rbtReceiver";
            this.rbtReceiver.SubItemsExpandWidth = 14;
            this.rbtReceiver.Text = "ข้อมูลค่าน้ำ / ค่าไฟ";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.rbaSetup);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 27);
            this.ribbonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(798, 64);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // rbaSetup
            // 
            this.rbaSetup.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbaSetup.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaSetup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbaSetup.ContainerControlProcessDialogKey = true;
            this.rbaSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbaSetup.DragDropSupport = true;
            this.rbaSetup.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtOrg});
            this.rbaSetup.Location = new System.Drawing.Point(0, 0);
            this.rbaSetup.Name = "rbaSetup";
            this.rbaSetup.Size = new System.Drawing.Size(798, 61);
            this.rbaSetup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbaSetup.TabIndex = 1;
            this.rbaSetup.Text = "ข้อมูลพื้นฐาน";
            // 
            // 
            // 
            this.rbaSetup.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbaSetup.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbtOrg
            // 
            this.rbtOrg.Name = "rbtOrg";
            this.rbtOrg.SubItemsExpandWidth = 14;
            this.rbtOrg.Text = "ข้อมูลหอพัก";
            this.rbtOrg.Click += new System.EventHandler(this.rbtOrg_Click);
            // 
            // rttFiles
            // 
            this.rttFiles.Name = "rttFiles";
            this.rttFiles.Panel = this.ribbonPanel1;
            this.rttFiles.Text = "ข้อมูลพื้นฐาน";
            // 
            // rttRoom
            // 
            this.rttRoom.Checked = true;
            this.rttRoom.Name = "rttRoom";
            this.rttRoom.Panel = this.ribbonPanel2;
            this.rttRoom.Text = "ห้องพัก";
            // 
            // rttTenant
            // 
            this.rttTenant.Name = "rttTenant";
            this.rttTenant.Panel = this.ribbonPanel3;
            this.rttTenant.Text = "ผู้เข่า";
            // 
            // rttReport
            // 
            this.rttReport.Name = "rttReport";
            this.rttReport.Panel = this.ribbonPanel4;
            this.rttReport.Text = "รายงาน";
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ribbonBar9.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar9.ContainerControlProcessDialogKey = true;
            this.ribbonBar9.DragDropSupport = true;
            this.ribbonBar9.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtSetup_Exit});
            this.ribbonBar9.Location = new System.Drawing.Point(733, 98);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(59, 78);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar9.TabIndex = 4;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbtSetup_Exit
            // 
            this.rbtSetup_Exit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.rbtSetup_Exit.CanCustomize = false;
            this.rbtSetup_Exit.Image = ((System.Drawing.Image)(resources.GetObject("rbtSetup_Exit.Image")));
            this.rbtSetup_Exit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbtSetup_Exit.Name = "rbtSetup_Exit";
            this.rbtSetup_Exit.Text = "เลิกงาน";
            this.rbtSetup_Exit.Click += new System.EventHandler(this.rbtSetup_Exit_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "ข้อมูลตั้งต้น";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 14;
            this.buttonItem5.Text = "สัญญาการเช่า";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(798, 416);
            this.Controls.Add(this.ribbonBar9);
            this.Controls.Add(this.rbMenu);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Apartment Smart";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.rbMenu.ResumeLayout(false);
            this.rbMenu.PerformLayout();
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem1;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem2;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem3;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem4;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem5;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem6;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem7;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonItem rbtSetup_Exit;
        private DevComponents.DotNetBar.RibbonTabItem rttFiles;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar rbaRoom;
        private DevComponents.DotNetBar.ButtonItem rbtProduct;
        private DevComponents.DotNetBar.RibbonTabItem rttRoom;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonBar rbaTenant;
        private DevComponents.DotNetBar.ButtonItem rbtTenant;
        private DevComponents.DotNetBar.RibbonTabItem rttTenant;
        private DevComponents.DotNetBar.ButtonItem rbtOrder;
        private DevComponents.DotNetBar.ButtonItem rbtReceiver;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar rbaSetup;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.ButtonItem rbtOrg;
        private DevComponents.DotNetBar.RibbonControl rbMenu;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar rbaReport;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.RibbonTabItem rttReport;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
    }
}

