using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess.Filters;
using Client.BLLs;

namespace Client.Modules
{
    public partial class 员工Module : BaseModule
    {
        public 员工Module()
        {
            InitializeComponent();
        }
        public override void InitModule(object modeldata = null)
        {
            base.InitModule(modeldata);
            InitEditors();
        }

        private void InitEditors()
        {
            EditorHelper.CheckedComboBoxEditor_门店信息(门店编码TextEdit.Properties);
        }

        private void bbiFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var filter = 员工信息FilterBindingSource.DataSource as 员工信息Filter;
            if (null == filter)
                filter = new 员工信息Filter();
            var list = 员工信息Logic.GetList(filter);
            员工信息ViewModelGridControl.DataSource = list;
            gridView1.AutoConfig();
        }
    }
}
