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
    public partial class 菜品Module : BaseModule
    {
        public 菜品Module()
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
            EditorHelper.CheckedComboBoxEditor_货品类别(菜品类别编码TextEdit.Properties);
            var filter = new 菜品信息Filter();
            菜品信息FilterBindingSource.DataSource = filter;
        }

        private void bbiFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //查询
            var filter = 菜品信息FilterBindingSource.DataSource as 菜品信息Filter;
            if (null == filter)
                filter = new 菜品信息Filter();
            var list = 菜品信息Logic.GetList(filter);
            菜品信息ViewModelBindingSource.DataSource = list;
            gridView1.AutoConfig();
            gridView2.AutoConfig();
        }
    }
}
