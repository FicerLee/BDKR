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
using DataAccess.EditModels;
using DataAccess;

namespace Client.Modules
{
    public partial class 门店Module : BaseModule
    {
        public 门店Module()
        {
            InitializeComponent();
        }
        public 门店ViewModel CurrentViewModel => gridView1.GetRow(gridView1.FocusedRowHandle) as 门店ViewModel;

        public override void InitModule(object modeldata = null)
        {
            //base.InitModule(modeldata);

        }

        private void bbiAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //新增门店
            var model = new 门店EditModel
            {
                编码 = 门店Logic.GetNewCode(),
                Action = ActionMode.新增
            };
            var result = EditorHelper.EditForm(model, this.FindForm());
            if (DialogResult.OK == result)
                LoadData();
        }

        private void LoadData()
        {
            //获取门店信息
            var list = 门店Logic.GetList();
            门店ViewModelBindingSource.DataSource = list;
            gridView1.AutoConfig();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (null == CurrentViewModel) return;
            var model = 门店Logic.GetEditModel(CurrentViewModel.编码);
            if (null == model) return;
            model.Action = ActionMode.修改;
            var result = EditorHelper.EditForm(model, this.FindForm());
            if (DialogResult.OK == result)
                LoadData();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (null == CurrentViewModel) return;
            if (DialogResult.Cancel == EditorHelper.Confirm("是否确认删除此仓库信息", "确认删除")) return;
            if (门店Logic.Remove(CurrentViewModel.编码) > 0)
                LoadData();
        }

        private void 门店Module_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
