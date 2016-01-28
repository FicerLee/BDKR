namespace Client
{
    partial class Main
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
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bsiLoginInfo = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.nbcMain = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgUsers = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUserList = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgBase = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiStoreInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMaterialInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDishInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.pcMain = new DevExpress.XtraEditors.PanelControl();
            this.nbi门店Info = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMain
            // 
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.bsiLoginInfo});
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.MaxItemId = 3;
            this.rcMain.Name = "rcMain";
            this.rcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.rcMain.Size = new System.Drawing.Size(884, 151);
            this.rcMain.StatusBar = this.ribbonStatusBar1;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bsiLoginInfo
            // 
            this.bsiLoginInfo.Caption = "barStaticItem1";
            this.bsiLoginInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bsiLoginInfo.Id = 2;
            this.bsiLoginInfo.Name = "bsiLoginInfo";
            this.bsiLoginInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "视图";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiLoginInfo);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(195, 478);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.rcMain;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(689, 23);
            // 
            // nbcMain
            // 
            this.nbcMain.ActiveGroup = this.nbgBase;
            this.nbcMain.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nbcMain.Appearance.GroupHeader.Options.UseFont = true;
            this.nbcMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbcMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgBase,
            this.nbgUsers});
            this.nbcMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiStoreInfo,
            this.nbiMaterialInfo,
            this.nbiDishInfo,
            this.nbiUserList,
            this.nbi门店Info});
            this.nbcMain.Location = new System.Drawing.Point(0, 151);
            this.nbcMain.Name = "nbcMain";
            this.nbcMain.OptionsNavPane.ExpandedWidth = 195;
            this.nbcMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcMain.Size = new System.Drawing.Size(195, 350);
            this.nbcMain.TabIndex = 1;
            this.nbcMain.Text = "navBarControl1";
            this.nbcMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbcMain_LinkClicked);
            // 
            // nbgUsers
            // 
            this.nbgUsers.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nbgUsers.Appearance.Options.UseFont = true;
            this.nbgUsers.Caption = "用户及权限";
            this.nbgUsers.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUserList)});
            this.nbgUsers.Name = "nbgUsers";
            // 
            // nbiUserList
            // 
            this.nbiUserList.Caption = "用户管理";
            this.nbiUserList.Name = "nbiUserList";
            // 
            // nbgBase
            // 
            this.nbgBase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.nbgBase.Appearance.Options.UseFont = true;
            this.nbgBase.Caption = "基本资料";
            this.nbgBase.Expanded = true;
            this.nbgBase.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbi门店Info),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiStoreInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMaterialInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDishInfo)});
            this.nbgBase.Name = "nbgBase";
            // 
            // nbiStoreInfo
            // 
            this.nbiStoreInfo.Caption = "仓库资料管理";
            this.nbiStoreInfo.Name = "nbiStoreInfo";
            // 
            // nbiMaterialInfo
            // 
            this.nbiMaterialInfo.Caption = "原材料信息维护";
            this.nbiMaterialInfo.Name = "nbiMaterialInfo";
            // 
            // nbiDishInfo
            // 
            this.nbiDishInfo.Caption = "菜品维护";
            this.nbiDishInfo.Name = "nbiDishInfo";
            // 
            // pcMain
            // 
            this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMain.Location = new System.Drawing.Point(195, 151);
            this.pcMain.Name = "pcMain";
            this.pcMain.Size = new System.Drawing.Size(689, 327);
            this.pcMain.TabIndex = 3;
            // 
            // nbi门店Info
            // 
            this.nbi门店Info.Caption = "门店管理";
            this.nbi门店Info.Name = "nbi门店Info";
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.nbcMain);
            this.Controls.Add(this.rcMain);
            this.Name = "Main";
            this.Ribbon = this.rcMain;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraNavBar.NavBarControl nbcMain;
        private DevExpress.XtraNavBar.NavBarGroup nbgBase;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.PanelControl pcMain;
        private DevExpress.XtraBars.BarStaticItem bsiLoginInfo;
        private DevExpress.XtraNavBar.NavBarItem nbiStoreInfo;
        private DevExpress.XtraNavBar.NavBarItem nbiMaterialInfo;
        private DevExpress.XtraNavBar.NavBarItem nbiDishInfo;
        private DevExpress.XtraNavBar.NavBarGroup nbgUsers;
        private DevExpress.XtraNavBar.NavBarItem nbiUserList;
        private DevExpress.XtraNavBar.NavBarItem nbi门店Info;
    }
}

