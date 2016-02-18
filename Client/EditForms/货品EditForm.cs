using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess.EditModels;

namespace Client.EditForms
{
    public partial class 货品EditForm : EditFormBase
    {
        private 货品信息EditModel model;
        public 货品EditForm(货品信息EditModel _model)
        {
            InitializeComponent();
            this.model = _model;
            InitEditors();
        }

        private void InitEditors()
        {
            EditorHelper.LookUpEdit_货品类别(货品类别LookUpEdit.Properties);
            this.Text = model.Action.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (model.Action)
                {
                    case ActionMode.新增:
                        break;
                    case ActionMode.修改:
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                EditorHelper.ShowErrorMsg(labelControl1, ex.Message);
            }
        }
    }
}