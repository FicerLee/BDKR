using Client.EditForms;
using DataAccess.EditModels;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using Client.BLLs;

namespace Client
{
    public class EditorHelper
    {
        /// <summary>
        /// 显示加载数据的对话框
        /// </summary>
        internal static void ShowWaitDialog(Form parentForm, string Caption = "请稍候...", string Description = "正在加载")
        {
            SplashScreenManager.ShowForm(parentForm, typeof(waitForm), false, false, false, false);
        }
        internal static void CloseWaitDialog()
        {
            SplashScreenManager.CloseForm(false);
        }

        internal static DialogResult EditForm(仓库EditModel model)
        {
            using (var _frm = new 仓库EditForm(model))
                return _frm.ShowDialog();
        }

        internal static void GridLookupEdit_门店信息(RepositoryItemGridLookUpEdit properties, string[] fields = null)
        {
            var list = 门店Logic.GetList();
            properties.DataSource = list;
            properties.ValueMember = "编码";
            properties.DisplayMember = "门店名称";
            properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            properties.ShowFooter = false;
            properties.View.AutoConfig();
            properties.View.BestFitColumns();
            if (null == fields)
                fields = new string[]
                {
                    "门店名称"
                };
            for (int i = 0; i < fields.Length; i++)
            {
                properties.View.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn
                {
                    FieldName = fields[i],
                    Caption = fields[i],
                    VisibleIndex = i
                });
            }
        }
    }
}
