using DataAccess;
using DataAccess.EditModels;
using DataAccess.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApis
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IBDKRWS”。
    [ServiceContract]
    public interface IBDKRWS
    {
        #region 门店

        [OperationContract]
        List<门店ViewModel> 门店信息_GetList();
        [OperationContract]
        void 门店信息_AddNew(门店EditModel model);
        [OperationContract]
        void 门店信息_Update(门店EditModel model);
        [OperationContract]
        void 门店信息_Delete(string 门店编码);
        [OperationContract]
        string 门店信息_GetNewCode();

        #endregion

        #region 员工信息
        [OperationContract]
        List<员工信息ViewModel> 员工信息_GetList(员工信息Filter filter);
        [OperationContract]
        void 员工信息_AddNew(员工信息EditModel model);
        [OperationContract]
        void 员工信息_Update(员工信息EditModel model);
        [OperationContract]
        void 员工信息_Delete(string 员工信息编码);
        [OperationContract]
        int 员工信息_BatchImport(员工信息EditModel model);
        [OperationContract]
        string 员工信息_GetNewCode();
        #endregion

        #region 工资单
        [OperationContract]
        List<工资表ViewModel> 工资表_GetList(工资表Filter filter);
        [OperationContract]
        int 工资表_BatchUpdate(List<工资表ViewModel> list);
        #endregion

        #region 仓库
        [OperationContract]
        List<仓库ViewModel> 仓库信息_GetList(仓库Filter filter);
        [OperationContract]
        string 仓库信息_GetNewCode();
        [OperationContract]
        int 仓库信息_Update(仓库EditModel model);
        [OperationContract]
        int 仓库信息_AddNew(仓库EditModel model);
        [OperationContract]
        int 仓库信息_Delete(string 仓库信息编码);
        #endregion

        #region 流水账清单
        [OperationContract]
        List<流水账明细清单ViewModel> 流水账明细清单_GetList(流水账明细Filter filter);
        [OperationContract]
        int 流水账明细清单_BatchUpdate(流水账清单EditModel model);
        #endregion

        #region 费用汇总表
        [OperationContract]
        List<费用汇总明细表ViewModel> 费用汇总明细表_GetList(费用汇总表Filter filter);
        [OperationContract]
        int 费用汇总明细表_BatchUpdate(List<费用汇总表EditModel> model);
        #endregion

        #region 日常费用
        [OperationContract]
        List<日常费用ViewModel> 日常费用_GetList(日常费用Filter filter);
        [OperationContract]
        int 日常费用_BatchUpdate(List<日常费用ViewModel> models);
        #endregion

        #region 损益表
        [OperationContract]
        List<损益表ViewModel> 损益表_GetList(损益表Filter filter);
        [OperationContract]
        int 损益表_BatchUpdate(List<损益表ViewModel> models);
        #endregion

        #region 货品表
        [OperationContract]
        List<货品信息ViewModel> 货品信息_GetList(货品信息Filter filter);
        [OperationContract]
        int 货品信息_AddNew(货品信息EditModel model);
        [OperationContract]
        int 货品信息_Update(货品信息EditModel model);
        [OperationContract]
        int 货品信息_Delete(string 货品信息编码);
        [OperationContract]
        string 货品信息_GetNewCode();
        #endregion

        #region 菜品信息
        [OperationContract]
        List<菜品信息ViewModel> 菜品信息_GetList(菜品信息Filter filter);
        [OperationContract]
        string 菜品信息_GetNewCode();
        [OperationContract]
        int 菜品信息_AddNew(菜品信息EditModel model);
        [OperationContract]
        int 菜品信息_Update(菜品信息EditModel model);
        [OperationContract]
        int 菜品信息_Delete(string 菜品信息编码);
        #endregion

        #region 库存信息
        [OperationContract]
        List<库存信息ViewModel> 库存信息_GetList(库存信息Filter filter);
        #endregion

        #region 采购订单

        #endregion

        #region 货品类别
        [OperationContract]
        List<货品类别ViewModel> 货品类别_GetList();
        [OperationContract]
        string 货品类别_GetNewCode();
        [OperationContract]
        int 货品类别_AddNew(货品类别EditModel model);
        [OperationContract]
        int 货品类别_Update(货品类别EditModel model);
        [OperationContract]
        int 货品类别_Delete(string 货品类别编码);
        #endregion

        #region 采购价格表
        [OperationContract]
        int 采购价格_AddNew(采购价格EditModel model);
        [OperationContract]
        string 采购价格_GetNewCode();
        #endregion

        #region 销售价格
        [OperationContract]
        int 销售价格_AddNew(销售价格EditModel model);
        [OperationContract]
        string 销售价格_GetNewCode();
        #endregion

    }
}
