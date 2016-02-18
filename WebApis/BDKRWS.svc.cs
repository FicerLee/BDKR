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
using System.Transactions;

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





        public int 费用汇总明细表_BatchUpdate(List<费用汇总表EditModel> model)
        {
            throw new NotImplementedException();
        }

        public List<费用汇总明细表ViewModel> 费用汇总明细表_GetList(费用汇总表Filter filter)
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

        public void 门店信息_AddNew(门店EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<门店信息>(context);
                var n = new 门店信息
                {
                    名称 = model.门店名称,
                    地址 = model.门店地址,
                    备注 = model.附加说明,
                    店长 = model.店长,
                    编码 = model.编码,
                    联系电话 = model.联系电话
                };
                r.AddNew(n, t => t.编码 == model.编码);
            }
        }

        public void 门店信息_Delete(string 门店编码)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<门店信息>(context);
                var e = r.GetSingle(t => t.编码 == 门店编码);
                if (null == e)
                    throw new Exception("门店信息并不存在");
                if (e.仓库信息List != null && e.仓库信息List.Count > 0)
                    throw new Exception("门店所属仓库信息存在");
                if (e.员工信息List != null && e.员工信息List.Count > 0)
                    throw new Exception("门店所属员工信息存在");
                if (e.实时库存明细List != null && e.实时库存明细List.Count > 0)
                    throw new Exception("门店所属实时库存信息存在");
                if (e.收支费用流水清单List != null && e.收支费用流水清单List.Count > 0)
                    throw new Exception("门店所属收支费用明细表存在");
                if (e.日常费用明细表List != null && e.日常费用明细表List.Count > 0)
                    throw new Exception("门店所属日常费用明细表存在");
                if (e.菜品销售单List != null && e.菜品销售单List.Count > 0)
                    throw new Exception("门店所属菜品销售单存在");
                if (e.费用汇总表List != null && e.费用汇总表List.Count > 0)
                    throw new Exception("门店所属费用汇总表存在");
                if (e.采购进货单List != null && e.采购进货单List.Count > 0)
                    throw new Exception("门店所属采购进货单存在");
                if (e.餐厅损益表List != null && e.餐厅损益表List.Count > 0)
                    throw new Exception("门店所属餐厅损益表存在");
                r.Remove(e, t => t.编码 == 门店编码);
            }
        }

        public void 门店信息_Update(门店EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<门店信息>(context);
                var e = r.GetSingle(t => t.编码 == model.编码);
                if (null == e)
                    throw new Exception("门店信息并不存在");
                r.Edit(e, t => t.编码 == model.编码);
            }
        }

        public int 货品信息_Delete(string 货品信息编码)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品信息>(context);
                var e = r.GetSingle(t => t.编码 == 货品信息编码);
                if (null == e)
                    throw new Exception("货品信息并不存在");
                if (e.实时库存List != null && e.实时库存List.Count > 0)
                    throw new Exception("实时库存存在此货品信息");
                if (e.货品BOMList != null && e.货品BOMList.Count > 0)
                    throw new Exception("货品BOM中存在此货品信息");
                if (e.采购进货单明细List != null && e.采购进货单明细List.Count > 0)
                    throw new Exception("采购进货单明细中存在此货品信息");
                return r.Remove(e, t => t.编码 == 货品信息编码);
            }
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

        #region 货品类别
        public List<货品类别ViewModel> 货品类别_GetList()
        {
            using (var context = new BDKRContext())
            {
                var list = new List<货品类别ViewModel>();
                context.货品类别S.ToList()
                    .ForEach(t =>
                    {
                        list.Add(t.ConvertToViewModel());
                    });
                return list;
            }
        }

        public string 货品类别_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品类别>(context);
                var maxcode = r.Max(t => t.编码, t => t.编码.StartsWith("LB")) ?? "LB000";
                var _max = int.Parse(maxcode.Substring(2));
                return "LB" + (_max + 1).ToString("000");
            }
        }

        public int 货品类别_AddNew(货品类别EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品类别>(context);
                var n = new 货品类别
                {
                    编码 = model.编码,
                    名称 = model.类别名称,
                    备注 = model.备注信息
                };
                return r.AddNew(n, t => t.编码 == model.编码);
            }
        }

        public int 货品类别_Update(货品类别EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品类别>(context);
                var e = r.GetSingle(t => t.编码 == model.编码);
                if (null == e)
                    throw new Exception("该类别信息并不存在");
                return r.Edit(e, t => t.编码 == model.编码);
            }
        }

        public int 货品类别_Delete(string 货品类别编码)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品类别>(context);
                var e = r.GetSingle(t => t.编码 == 货品类别编码);
                if (null == e)
                    throw new Exception("该类别信息并不存在");
                return r.Remove(e, t => t.编码 == 货品类别编码);
            }
        }
        #endregion

        #region 货品信息
        public int 货品信息_AddNew(货品信息EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<货品信息>(context);
                var n = new 货品信息
                {
                    单位 = model.单位,
                    名称 = model.货品名称,
                    备注 = model.附加说明,
                    拼音 = UtilHelper.PinYin(model.货品名称),
                    是否菜品 = false,
                    编码 = model.编码,
                    规格 = model.规格型号,
                    货品类别编码 = model.货品类别
                };
                //TODO:未考虑价格因素
                return r.AddNew(n, t => t.编码 == model.编码);
            }
        }

        public List<货品信息ViewModel> 货品信息_GetList(货品信息Filter filter)
        {
            using (var context = new BDKRContext())
            {
                var q = from t in context.货品信息S
                        select t;
                if (filter.关键词 != null && filter.关键词.Length > 0)
                    q = from t in q
                        where (t.名称 != null && t.名称.Contains(filter.关键词))
                        || (t.拼音 != null && t.拼音.Contains(filter.关键词))
                        select t;
                if (filter.货品类别编码 != null && filter.货品类别编码.Length > 0)
                {
                    q = from t in q
                        where filter.货品类别编码.Contains(filter.货品类别编码)
                        select t;
                }
                //TODO:价格区间暂时未做
                var list = new List<货品信息ViewModel>();
                q.ToList()
                    .ForEach(t =>
                    {
                        list.Add(t.ConvertToViewModel());
                    });
                return list;
            }
        }

        public int 货品信息_Update(货品信息EditModel model)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 员工信息
        public void 员工信息_AddNew(员工信息EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<员工信息>(context);
                var n = new 员工信息
                {
                    入职日期 = model.入职日期,
                    姓名 = model.员工姓名,
                    工号 = model.工号,
                    当前基本工资 = model.当前基本工资,
                    拼音 = UtilHelper.PinYin(model.员工姓名),
                    编码 = model.编码,
                    职位 = model.职位,
                    联系电话 = model.联系电话,
                    身份证号 = model.身份证号,
                    门店编码 = model.门店编码,
                    附加说明 = model.附加说明
                };
                r.AddNew(n, t => t.编码 == model.编码);
            }
        }

        public int 员工信息_BatchImport(员工信息EditModel model)
        {
            throw new NotImplementedException();
            //TODO:员工信息批量导入
        }

        public void 员工信息_Delete(string 员工信息编码)
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<员工信息>(context);
                var e = r.GetSingle(t => t.编码 == 员工信息编码);
                if (null == e)
                    throw new Exception("该员工信息不存在");
                r.Remove(e, t => t.编码 == 员工信息编码);
            }
        }

        public List<员工信息ViewModel> 员工信息_GetList(员工信息Filter filter)
        {
            using (var context = new BDKRContext())
            {
                var q = from t in context.员工信息S
                        select t;
                if (filter.关键词 != null && filter.关键词.Length > 0)
                    q = from t in q
                        where (t.姓名 != null && t.姓名.Contains(filter.关键词))
                        || (t.拼音 != null && t.拼音.Contains(filter.关键词))
                        || (t.工号 != null && t.工号.Contains(filter.关键词))
                        || (t.联系电话 != null && t.联系电话.Contains(filter.关键词))
                        || (t.身份证号 != null && t.身份证号.Contains(filter.关键词))
                        select t;
                if (filter.门店编码 != null && filter.门店编码.Length > 0)
                    q = from t in q
                        where filter.门店编码.Contains(t.门店编码)
                        select t;
                var list = new List<员工信息ViewModel>();
                q.ToList()
                    .ForEach(t =>
                    {
                        list.Add(t.ConvertToViewModel());
                    });
                return list;
            }
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
            using (var context = new BDKRContext())
            {
                var r = new Repository<员工信息>(context);
                var e = r.GetSingle(t => t.编码 == model.编码);
                if (null == e)
                    throw new Exception("员工信息并不存在");
                if (e.姓名 != model.员工姓名)
                    e.拼音 = UtilHelper.PinYin(model.员工姓名);
                e.姓名 = model.员工姓名;
                e.入职日期 = model.入职日期;
                e.工号 = model.工号;
                e.当前基本工资 = model.当前基本工资;
                e.职位 = model.职位;
                e.联系电话 = model.联系电话;
                e.身份证号 = model.身份证号;
                e.门店编码 = model.门店编码;
                e.附加说明 = model.附加说明;
                r.Edit(e, t => t.编码 == model.编码);
            }
        }
        #endregion

        #region 菜品信息
        public int 菜品信息_AddNew(菜品信息EditModel model)
        {
            int _count = 0;
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                using (var context = new BDKRContext())
                {
                    var r = new Repository<货品信息>(context);
                    var e = r.GetSingle(t => t.编码 == model.编码);
                    if (null != e)
                        throw new Exception("菜品信息当前已存在");
                    e = new 货品信息
                    {
                        单位 = model.单位,
                        名称 = model.菜品名称,
                        备注 = model.附加说明,
                        拼音 = UtilHelper.PinYin(model.菜品名称),
                        是否菜品 = true,
                        编码 = model.编码,
                        规格 = model.规格,
                        货品类别编码 = model.菜品类别
                    };
                    if (model.当前销售价格 > 0)
                    {
                        var cj = new 销售价格表
                        {
                            价格 = model.当前销售价格,
                            创建时间 = DateTime.Now,
                            编码 = 销售价格_GetNewCode(),
                            货品信息编码 = model.编码,
                            附加说明 = ""
                        };
                        var _jg = new Repository<销售价格表>(context);
                        _jg.AddNew(cj);
                    }
                    _count = r.AddNew(e);
                }
                ts.Complete();
            }
            return _count;
        }

        public int 菜品信息_Delete(string 菜品信息编码)
        {
            throw new NotImplementedException();
        }

        public List<菜品信息ViewModel> 菜品信息_GetList(菜品信息Filter filter)
        {
            using (var context = new BDKRContext())
            {
                var q = from t in context.货品信息S
                        where t.是否菜品 == true
                        select t;
                if (filter.关键词 != null && filter.关键词.Length > 0)
                    q = from t in q
                        where (t.名称 != null && t.名称.Contains(filter.关键词))
                        || (t.拼音 != null && t.拼音.Contains(filter.关键词))
                        select t;
                if (filter.菜品类别编码 != null && filter.菜品类别编码.Length > 0)
                    q = from t in q
                        where (filter.菜品类别编码.Contains(t.货品类别编码))
                        select t;
                var list = new List<菜品信息ViewModel>();
                q.ToList()
                    .ForEach(t =>
                    {
                        list.Add(t.ConvertToViewModel_菜品信息());
                    });
                return list;
            }
        }

        public string 菜品信息_GetNewCode()
        {
            return 货品信息_GetNewCode();
        }

        public int 菜品信息_Update(菜品信息EditModel model)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region 采购价格
        public int 采购价格_AddNew(采购价格EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var _货品 = context.货品信息S.FirstOrDefault(t => t.编码 == model.货品信息编码);
                if (null == _货品)
                    throw new Exception("货品信息并不存在");
                var _o = context.采购价格表S.Where(t => t.货品信息编码 == model.货品信息编码)
                    .OrderByDescending(t => t.创建时间).FirstOrDefault();
                if (null == _o || _o.价格 != model.当前采购成本价)
                {
                    var _n = new 采购成本价格表
                    {
                        价格 = model.当前采购成本价,
                        创建时间 = DateTime.Now,
                        编码 = model.编码,
                        货品信息编码 = model.货品信息编码,
                        附加说明 = model.附加说明
                    };
                    context.采购价格表S.Add(_n);
                }
                return context.SaveChanges();
            }
        }

        public string 采购价格_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<采购成本价格表>(context);
                var maxcode = r.Max<string>(t => t.编码, t => t.编码.StartsWith("CJ")) ?? "CJ0000";
                return "CJ" + (int.Parse(maxcode.Substring(2)) + 1).ToString("0000");
            }
        }

        #endregion

        #region 销售价格
        public int 销售价格_AddNew(销售价格EditModel model)
        {
            using (var context = new BDKRContext())
            {
                var _货品 = context.货品信息S.FirstOrDefault(t => t.编码 == model.货品信息编码);
                if (null == _货品)
                    throw new Exception("菜品信息并不存在");
                var _o = context.销售价格表S.Where(t => t.货品信息编码 == model.货品信息编码)
                    .OrderByDescending(t => t.创建时间).FirstOrDefault();
                if (null == _o || _o.价格 != model.当前销售价格)
                {
                    var _n = new 销售价格表
                    {
                        价格 = model.当前销售价格,
                        创建时间 = DateTime.Now,
                        编码 = model.编码,
                        货品信息编码 = model.货品信息编码,
                        附加说明 = model.附加说明
                    };
                    context.销售价格表S.Add(_n);
                }
                return context.SaveChanges();
            }
        }

        public string 销售价格_GetNewCode()
        {
            using (var context = new BDKRContext())
            {
                var r = new Repository<销售价格表>(context);
                var maxcode = r.Max<string>(t => t.编码, t => t.编码.StartsWith("XJ")) ?? "XJ0000";
                return "XJ" + (int.Parse(maxcode.Substring(2)) + 1).ToString("0000");
            }
        }
        #endregion
    }
}
