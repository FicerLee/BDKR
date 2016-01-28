using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Client.BLLs;

namespace Client.Modules
{
    public partial class 仓库Module : BaseModule
    {
        public 仓库Module()
        {
            InitializeComponent();
        }
        public override void InitModule(object modeldata = null)
        {
            base.InitModule(modeldata);
            LoadData();
        }

        private void LoadData()
        {
            var list = 仓库Logic.GetList();
            仓库ViewModelBindingSource.DataSource = list;
            gridView1.AutoConfig();
        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //新增仓库
            var model = 仓库Logic.CreateNewEditModel();
            var ret = EditorHelper.EditForm(model);
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
