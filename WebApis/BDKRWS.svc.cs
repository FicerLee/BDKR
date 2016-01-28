using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
using DataAccess.Filters;
using WebApis.Models;

namespace WebApis
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“BDKRWS”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 BDKRWS.svc 或 BDKRWS.svc.cs，然后开始调试。
    public class BDKRWS : IBDKRWS
    {

        #region 仓库信息

        public string 仓库信息_CreateNewCode()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<仓库信息>(context);
                var maxcode = rep.Max<string>(t => t.编码, t => t.编码.StartsWith("C")) ?? "C00";
                var _max = int.Parse(maxcode.Substring(1));
                return string.Format("C{0}", (_max + 1).ToString("00"));
            }
        }
        public List<仓库ViewModel> 仓库信息_GetList(仓库Filter filter)
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<仓库信息>(context);
                return rep.GetList<仓库ViewModel>(t => t.ConvertToViewModel(), t =>
                   {
                       if (filter != null)
                       {
                           if (filter.关键词.Length > 0 && !filter.关键词.Contains(t.仓库名称)) return false;
                       }
                       return true;
                   });
            }
        }

        #endregion

        #region 门店
        public List<门店ViewModel> 门店信息_GetList()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<门店信息>(context);
                return rep.GetList<门店ViewModel>(t => t.ConvertToViewModel());
            }
        }
        #endregion

    }
}
