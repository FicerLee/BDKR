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
    public partial class 仓库EditForm : EditFormBase
    {
        private 仓库EditModel _model;
        public 仓库EditForm()
        {
            InitializeComponent();
        }

        public 仓库EditForm(仓库EditModel model) : this()
        {
            this._model = model;
            this.Load += 仓库EditForm_Load;
        }

        private void 仓库EditForm_Load(object sender, EventArgs e)
        {
            InitEditors();
            仓库EditModelBindingSource.DataSource = _model;
        }

        private void InitEditors()
        {
            EditorHelper.GridLookupEdit_门店信息(门店编码TextEdit.Properties);
        }
    }
}