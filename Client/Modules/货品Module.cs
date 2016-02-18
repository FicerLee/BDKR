using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess.EditModels;
using DataAccess.Filters;
using Client.BLLs;

namespace Client.Modules
{
    public partial class 货品Module : BaseModule
    {
        public 货品Module()
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
            EditorHelper.CheckedComboBoxEditor_货品类别(货品类别CheckComboBox.Properties);
            var filter = new 货品信息Filter();
            货品信息FilterBindingSource.DataSource = filter;
        }

        private void bbiSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var filter = 货品信息FilterBindingSource.DataSource as 货品信息Filter;
            var list = 货品信息Logic.GetList(filter);
            gridControl1.DataSource = list;
            gridView1.AutoConfig();
        }
    }
}
