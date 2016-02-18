using Client.BLLs;
using Client.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ModuleNavigator navigator;
        public Main()
        {
            InitializeComponent();
            navigator = new ModuleNavigator(rcMain, pcMain);
            InitEditors();
        }

        private void InitEditors()
        {
            bsiLoginInfo.Caption = LoginLogic.GetLoginInfo();
            InitNavigators();
        }

        private void InitNavigators()
        {
            nbiStoreInfo.Tag = new NavModuleObject(nbiStoreInfo.Caption, typeof(仓库Module));
            nbi门店Info.Tag = new NavModuleObject(nbi门店Info.Caption, typeof(门店Module));
            nbiMaterialInfo.Tag = new NavModuleObject(nbiMaterialInfo.Caption, typeof(货品Module));
            nbi员工Info.Tag = new NavModuleObject(nbi员工Info.Caption, typeof(员工Module));
        }

        private void nbcMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link == null) return;
            navigator.CheckSelectedItem(e.Link);
        }
    }
}
