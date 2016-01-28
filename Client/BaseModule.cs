using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace Client
{
    public partial class BaseModule : DevExpress.XtraEditors.XtraUserControl
    {
        public BaseModule()
        {
            InitializeComponent();
        }

        public RibbonControl ChildRibbon => this.Controls.OfType<RibbonControl>().FirstOrDefault();

        public virtual void InitModule(object modeldata = null)
        {
            //覆盖到Main中
        }
    }
}
