using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;

namespace Client
{
    public partial class LoginForm : EditFormBase
    {
        private LoginModel model;
        public LoginForm()
        {
            InitializeComponent();
            model = new LoginModel();
            InitEditors();
        }

        private void InitEditors()
        {
            lblMsg.Text = "";
            loginModelBindingSource.DataSource = model;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}