namespace Client.Modules
{
    partial class 员工Module
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFind = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.员工信息ViewModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.员工信息ViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col编码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col姓名 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col基本工资 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col身份证号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col联系方式 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col入职日期 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附加说明 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col门店编码 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col门店 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col工龄 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.员工信息FilterDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.关键词TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.员工信息FilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.门店编码TextEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFor门店编码 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFor关键词 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息ViewModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息ViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息FilterDataLayoutControl)).BeginInit();
            this.员工信息FilterDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.关键词TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息FilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.门店编码TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFor门店编码)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFor关键词)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiAddNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiImport,
            this.bbiFind});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(768, 144);
            // 
            // bbiAddNew
            // 
            this.bbiAddNew.Caption = "新增";
            this.bbiAddNew.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiAddNew.Id = 1;
            this.bbiAddNew.ImageUri.Uri = "Add";
            this.bbiAddNew.Name = "bbiAddNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "修改";
            this.bbiEdit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除";
            this.bbiDelete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "批量新增";
            this.bbiImport.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiImport.Id = 4;
            this.bbiImport.ImageUri.Uri = "IndentDecrease";
            this.bbiImport.Name = "bbiImport";
            // 
            // bbiFind
            // 
            this.bbiFind.Caption = "搜索";
            this.bbiFind.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiFind.Id = 5;
            this.bbiFind.ImageUri.Uri = "Find";
            this.bbiFind.Name = "bbiFind";
            this.bbiFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFind_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAddNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImport, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiFind);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.员工信息ViewModelGridControl);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 144);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(684, 196, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(768, 449);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // 员工信息ViewModelGridControl
            // 
            this.员工信息ViewModelGridControl.DataSource = this.员工信息ViewModelBindingSource;
            this.员工信息ViewModelGridControl.Location = new System.Drawing.Point(12, 71);
            this.员工信息ViewModelGridControl.MainView = this.gridView1;
            this.员工信息ViewModelGridControl.MenuManager = this.ribbonControl1;
            this.员工信息ViewModelGridControl.Name = "员工信息ViewModelGridControl";
            this.员工信息ViewModelGridControl.Size = new System.Drawing.Size(744, 366);
            this.员工信息ViewModelGridControl.TabIndex = 0;
            this.员工信息ViewModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // 员工信息ViewModelBindingSource
            // 
            this.员工信息ViewModelBindingSource.DataSource = typeof(DataAccess.员工信息ViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col编码,
            this.col姓名,
            this.col工号,
            this.col基本工资,
            this.col身份证号,
            this.col联系方式,
            this.col入职日期,
            this.col附加说明,
            this.col门店编码,
            this.col门店,
            this.col工龄});
            this.gridView1.GridControl = this.员工信息ViewModelGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // col编码
            // 
            this.col编码.FieldName = "编码";
            this.col编码.Name = "col编码";
            this.col编码.Visible = true;
            this.col编码.VisibleIndex = 0;
            // 
            // col姓名
            // 
            this.col姓名.FieldName = "姓名";
            this.col姓名.Name = "col姓名";
            this.col姓名.Visible = true;
            this.col姓名.VisibleIndex = 1;
            // 
            // col工号
            // 
            this.col工号.FieldName = "工号";
            this.col工号.Name = "col工号";
            this.col工号.Visible = true;
            this.col工号.VisibleIndex = 2;
            // 
            // col基本工资
            // 
            this.col基本工资.FieldName = "基本工资";
            this.col基本工资.Name = "col基本工资";
            this.col基本工资.Visible = true;
            this.col基本工资.VisibleIndex = 3;
            // 
            // col身份证号
            // 
            this.col身份证号.FieldName = "身份证号";
            this.col身份证号.Name = "col身份证号";
            this.col身份证号.Visible = true;
            this.col身份证号.VisibleIndex = 4;
            // 
            // col联系方式
            // 
            this.col联系方式.FieldName = "联系方式";
            this.col联系方式.Name = "col联系方式";
            this.col联系方式.Visible = true;
            this.col联系方式.VisibleIndex = 5;
            // 
            // col入职日期
            // 
            this.col入职日期.FieldName = "入职日期";
            this.col入职日期.Name = "col入职日期";
            this.col入职日期.Visible = true;
            this.col入职日期.VisibleIndex = 6;
            // 
            // col附加说明
            // 
            this.col附加说明.FieldName = "附加说明";
            this.col附加说明.Name = "col附加说明";
            this.col附加说明.Visible = true;
            this.col附加说明.VisibleIndex = 7;
            // 
            // col门店编码
            // 
            this.col门店编码.FieldName = "门店编码";
            this.col门店编码.Name = "col门店编码";
            this.col门店编码.Visible = true;
            this.col门店编码.VisibleIndex = 8;
            // 
            // col门店
            // 
            this.col门店.FieldName = "门店";
            this.col门店.Name = "col门店";
            this.col门店.Visible = true;
            this.col门店.VisibleIndex = 9;
            // 
            // col工龄
            // 
            this.col工龄.FieldName = "工龄";
            this.col工龄.Name = "col工龄";
            this.col工龄.OptionsColumn.ReadOnly = true;
            this.col工龄.Visible = true;
            this.col工龄.VisibleIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.员工信息FilterDataLayoutControl);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(744, 38);
            this.panelControl1.TabIndex = 4;
            // 
            // 员工信息FilterDataLayoutControl
            // 
            this.员工信息FilterDataLayoutControl.Controls.Add(this.关键词TextEdit);
            this.员工信息FilterDataLayoutControl.Controls.Add(this.门店编码TextEdit);
            this.员工信息FilterDataLayoutControl.DataSource = this.员工信息FilterBindingSource;
            this.员工信息FilterDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.员工信息FilterDataLayoutControl.Location = new System.Drawing.Point(2, 2);
            this.员工信息FilterDataLayoutControl.Name = "员工信息FilterDataLayoutControl";
            this.员工信息FilterDataLayoutControl.Root = this.layoutControlGroup2;
            this.员工信息FilterDataLayoutControl.Size = new System.Drawing.Size(359, 34);
            this.员工信息FilterDataLayoutControl.TabIndex = 0;
            this.员工信息FilterDataLayoutControl.Text = "dataLayoutControl1";
            // 
            // 关键词TextEdit
            // 
            this.关键词TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.员工信息FilterBindingSource, "关键词", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.关键词TextEdit.Location = new System.Drawing.Point(58, 7);
            this.关键词TextEdit.MenuManager = this.ribbonControl1;
            this.关键词TextEdit.Name = "关键词TextEdit";
            this.关键词TextEdit.Size = new System.Drawing.Size(119, 20);
            this.关键词TextEdit.StyleController = this.员工信息FilterDataLayoutControl;
            this.关键词TextEdit.TabIndex = 5;
            // 
            // 员工信息FilterBindingSource
            // 
            this.员工信息FilterBindingSource.DataSource = typeof(DataAccess.Filters.员工信息Filter);
            // 
            // 门店编码TextEdit
            // 
            this.门店编码TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.员工信息FilterBindingSource, "门店编码", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.门店编码TextEdit.Location = new System.Drawing.Point(232, 7);
            this.门店编码TextEdit.MenuManager = this.ribbonControl1;
            this.门店编码TextEdit.Name = "门店编码TextEdit";
            this.门店编码TextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.门店编码TextEdit.Size = new System.Drawing.Size(120, 20);
            this.门店编码TextEdit.StyleController = this.员工信息FilterDataLayoutControl;
            this.门店编码TextEdit.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(359, 34);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFor门店编码,
            this.ItemFor关键词});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(349, 24);
            // 
            // ItemFor门店编码
            // 
            this.ItemFor门店编码.Control = this.门店编码TextEdit;
            this.ItemFor门店编码.Location = new System.Drawing.Point(174, 0);
            this.ItemFor门店编码.Name = "ItemFor门店编码";
            this.ItemFor门店编码.Size = new System.Drawing.Size(175, 24);
            this.ItemFor门店编码.Text = "门店编码";
            this.ItemFor门店编码.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemFor关键词
            // 
            this.ItemFor关键词.Control = this.关键词TextEdit;
            this.ItemFor关键词.Location = new System.Drawing.Point(0, 0);
            this.ItemFor关键词.Name = "ItemFor关键词";
            this.ItemFor关键词.Size = new System.Drawing.Size(174, 24);
            this.ItemFor关键词.Text = "关键词";
            this.ItemFor关键词.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(768, 449);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(748, 42);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.员工信息ViewModelGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(748, 387);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(105, 14);
            // 
            // 员工Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "员工Module";
            this.Size = new System.Drawing.Size(768, 593);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.员工信息ViewModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息ViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.员工信息FilterDataLayoutControl)).EndInit();
            this.员工信息FilterDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.关键词TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.员工信息FilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.门店编码TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFor门店编码)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFor关键词)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiAddNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl 员工信息ViewModelGridControl;
        private System.Windows.Forms.BindingSource 员工信息ViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn col编码;
        private DevExpress.XtraGrid.Columns.GridColumn col姓名;
        private DevExpress.XtraGrid.Columns.GridColumn col工号;
        private DevExpress.XtraGrid.Columns.GridColumn col基本工资;
        private DevExpress.XtraGrid.Columns.GridColumn col身份证号;
        private DevExpress.XtraGrid.Columns.GridColumn col联系方式;
        private DevExpress.XtraGrid.Columns.GridColumn col入职日期;
        private DevExpress.XtraGrid.Columns.GridColumn col附加说明;
        private DevExpress.XtraGrid.Columns.GridColumn col门店编码;
        private DevExpress.XtraGrid.Columns.GridColumn col门店;
        private DevExpress.XtraGrid.Columns.GridColumn col工龄;
        private DevExpress.XtraBars.BarButtonItem bbiFind;
        private DevExpress.XtraDataLayout.DataLayoutControl 员工信息FilterDataLayoutControl;
        private System.Windows.Forms.BindingSource 员工信息FilterBindingSource;
        private DevExpress.XtraEditors.TextEdit 关键词TextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemFor门店编码;
        private DevExpress.XtraLayout.LayoutControlItem ItemFor关键词;
        private DevExpress.XtraEditors.CheckedComboBoxEdit 门店编码TextEdit;
    }
}
