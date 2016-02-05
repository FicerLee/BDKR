using Client.BLLs;
using DataAccess.EditModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.EditForms
{
    public partial class 门店信息EditForm : EditFormBase
    {
        private 门店EditModel model;
        public 门店信息EditForm(门店EditModel model)
        {
            InitializeComponent();
            this.model = model;
            InitEditors();
        }

        private void InitEditors()
        {
            门店EditModelBindingSource.DataSource = model;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (model.Action)
                {
                    case ActionMode.新增:
                        门店Logic.AddNew(model);
                        break;
                    case ActionMode.修改:
                        门店Logic.Update(model);
                        break;
                    case ActionMode.删除:
                        门店Logic.Delete(model.编码);
                        break;
                    case ActionMode.浏览:
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                labelControl1.Text = ex.Message;
            }

        }
    }
}
