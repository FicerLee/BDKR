using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
using DataAccess.EditModels;
using DataAccess.Filters;
using WebApis.Models;

namespace WebApis
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“BDKRWS”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 BDKRWS.svc 或 BDKRWS.svc.cs，然后开始调试。
    public class BDKRWS : IBDKRWS
    {
        public int 仓库信息_AddNew(仓库EditModel model)
        {
            throw new NotImplementedException();
        }

        #region 仓库信息

        public string 仓库信息_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<仓库信息>(context);
                var maxcode = rep.Max<string>(t => t.编码, t => t.编码.StartsWith("C")) ?? "C00";
                var _max = int.Parse(maxcode.Substring(1));
                return string.Format("C{0}", (_max + 1).ToString("00"));
            }
        }

        public int 仓库信息_Delete(string 仓库信息编码)
        {
            throw new NotImplementedException();
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

        public int 仓库信息_Update(仓库EditModel model)
        {
            throw new NotImplementedException();
        }

        public void 员工信息_AddNew(员工信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 员工信息_BatchImport(员工信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public void 员工信息_Delete(string 员工信息编码)
        {
            throw new NotImplementedException();
        }

        public List<员工信息ViewModel> 员工信息_GetList(员工信息Filter filter)
        {
            throw new NotImplementedException();
        }

        public string 员工信息_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<员工信息>(context);
                var maxcode = rep.Max<string>(t => t.编码, t => t.编码.StartsWith("YG")) ?? "YG000";
                var _max = int.Parse(maxcode.Substring(2));
                return string.Format("YG{0}", (_max + 1).ToString("000"));
            }
        }

        public void 员工信息_Update(员工信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 工资表_BatchUpdate(List<工资表ViewModel> list)
        {
            throw new NotImplementedException();
        }

        public List<工资表ViewModel> 工资表_GetList(工资表Filter filter)
        {
            throw new NotImplementedException();
        }

        public List<库存信息ViewModel> 库存信息_GetList(库存信息Filter filter)
        {
            throw new NotImplementedException();
        }

        public int 损益表_BatchUpdate(List<损益表ViewModel> models)
        {
            throw new NotImplementedException();
        }

        public List<损益表ViewModel> 损益表_GetList(损益表Filter filter)
        {
            throw new NotImplementedException();
        }

        public int 日常费用_BatchUpdate(List<日常费用ViewModel> models)
        {
            throw new NotImplementedException();
        }

        public List<日常费用ViewModel> 日常费用_GetList(日常费用Filter filter)
        {
            throw new NotImplementedException();
        }

        public int 流水账明细清单_BatchUpdate(流水账清单EditModel model)
        {
            throw new NotImplementedException();
        }

        public List<流水账明细清单ViewModel> 流水账明细清单_GetList(流水账明细Filter filter)
        {
            throw new NotImplementedException();
        }

        public int 菜品信息_AddNew(菜品信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 菜品信息_Delete(string 菜品信息编码)
        {
            throw new NotImplementedException();
        }

        public List<菜品信息ViewModel> 菜品信息_GetList(菜品信息Filter filter)
        {
            throw new NotImplementedException();
        }

        public string 菜品信息_GetNewCode()
        {
            return 货品信息_GetNewCode();
        }

        public int 菜品信息_Update(菜品信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 货品信息_AddNew(货品信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public List<货品信息ViewModel> 货品信息_GetList(货品信息Filter filter)
        {
            throw new NotImplementedException();
        }

        public int 货品信息_Update(货品信息EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 费用汇总明细表_BatchUpdate(List<费用汇总表EditModel> model)
        {
            throw new NotImplementedException();
        }

        public List<费用汇总明细表ViewModel> 费用汇总明细表_GetList(费用汇总表Filter filter)
        {
            throw new NotImplementedException();
        }

        public void 门店信息_AddNew(门店EditModel model)
        {
            throw new NotImplementedException();
        }

        public void 门店信息_Delete(string 门店编码)
        {
            throw new NotImplementedException();
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

        public string 门店信息_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<门店信息>(context);
                var maxcode = rep.Max<string>(t => t.编码, t => t.编码.StartsWith("MD")) ?? "MD00";
                var _max = int.Parse(maxcode.Substring(2));
                return string.Format("MD{0}", (_max + 1).ToString("00"));
            }
        }

        public void 门店信息_Update(门店EditModel model)
        {
            throw new NotImplementedException();
        }

        public int 货品信息_Delete(string 货品信息编码)
        {
            throw new NotImplementedException();
        }

        public string 货品信息_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var rep = new Repository<货品信息>(context);
                var maxcode = rep.Max<string>(t => t.编码, t => t.编码.StartsWith("HP")) ?? "HP0000";
                var _max = int.Parse(maxcode.Substring(2));
                return string.Format("HP{0}", (_max + 1).ToString("0000"));
            }
        }
        #endregion

    }
}
