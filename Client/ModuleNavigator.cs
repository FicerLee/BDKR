using Client.Modules;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public class ModuleNavigator
    {
        public ModuleNavigator(RibbonControl ribbon, PanelControl panel)
        {
            this.Panel = panel;
            this.Ribbon = ribbon;
        }
        public RibbonControl Ribbon { get; }
        public PanelControl Panel { get; }

        public BaseModule CurrentModule => Panel.Controls.Count == 0 ? null : Panel.Controls[0] as BaseModule;

        public void CheckSelectedItem(NavBarItemLink link, object moduledata = null)
        {
            //try
            //{
            var navmoduleobject = link?.Item.Tag as NavModuleObject;
            if (navmoduleobject == null) return;
            var firstshow = navmoduleobject.Module == null;
            Ribbon.UnMergeRibbon();
            //以上没问题
            if (firstshow)
            {
                SplashScreenManager.ShowForm(this.Ribbon.FindForm(), typeof(waitForm), false, true);
                //if (SplashScreenManager.Default == null)
                //{
                //    SplashScreenManager.ShowForm(this.Ribbon.FindForm(), typeof(waitForm), false, true);
                //}
                var constructureInfo = navmoduleobject.ModuleType.GetConstructor(Type.EmptyTypes);
                if (constructureInfo != null)
                {
                    navmoduleobject.Module = constructureInfo.Invoke(null) as BaseModule;
                    navmoduleobject.Module?.InitModule();
                }
                if (SplashScreenManager.Default == null) return;
                //以上代码存在问题
                var frm = moduledata as Form;
                if (frm != null)
                {
                    if (SplashScreenManager.FormInPendingState)
                    {
                        SplashScreenManager.CloseForm();
                    }
                    else
                    {
                        SplashScreenManager.CloseForm(false, 500, frm);
                    }
                }
                else
                    SplashScreenManager.CloseForm();
            }
            if (navmoduleobject.Module == null) return;
            Panel.Controls.Clear();
            Panel.Controls.Add(navmoduleobject.Module);
            navmoduleobject.Module.Dock = DockStyle.Fill;
            //如果Module上有ribbon，合并
            if (navmoduleobject.Module.ChildRibbon != null)
            {
                navmoduleobject.Module.ChildRibbon.Pages[0].Text = navmoduleobject.Name;
                this.Ribbon.MergeRibbon(navmoduleobject.Module.ChildRibbon);
                int length = this.Ribbon.MergedPages.Count;
                if (length > 0)
                    this.Ribbon.SelectedPage = this.Ribbon.MergedPages[length - 1];
            }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

        }
    }

}
