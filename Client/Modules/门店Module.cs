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
    public partial class 门店Module : BaseModule
    {
        public 门店Module()
        {
            InitializeComponent();
        }

        public override void InitModule(object modeldata = null)
        {
            //base.InitModule(modeldata);

        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void 门店Module_Load(object sender, EventArgs e)
        {
            //获取门店信息
            var list = 门店Logic.GetList();
            门店ViewModelBindingSource.DataSource = list;
            gridView1.AutoConfig();
        }
    }
}
