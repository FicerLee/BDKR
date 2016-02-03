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
        void 门店信息_Edit(门店EditModel model);
        [OperationContract]
        void 门店信息_Remove(string 门店编码);

        #endregion

        #region 员工信息
        [OperationContract]
        List<员工信息ViewModel> 员工信息_GetList(员工信息Filter filter);
        [OperationContract]
        void 员工信息_AddNew(员工信息EditModel model);
        [OperationContract]
        void 员工信息_Edit(员工信息EditModel model);
        [OperationContract]
        void 员工信息_Remove(string 员工信息编码);
        [OperationContract]
        int 员工信息_BatchImport(员工信息EditModel model);
        #endregion

        #region 工资单
        [OperationContract]
        List<工资表ViewModel> 工资表_GetList(工资表Filter filter);
        int 工资表_BatchUpdate(List<工资表ViewModel> list);
        #endregion

        #region 仓库
        [OperationContract]
        List<仓库ViewModel> 仓库信息_GetList(仓库Filter filter);
        [OperationContract]
        string 仓库信息_CreateNewCode();
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
        int 费用汇总明细表_BatchUpdate(List<费用汇总表EditModel> model);
        #endregion

        #region 日常费用
        [OperationContract]
        List<日常费用ViewModel> 日常费用_GetList(日常费用Filter filter);
        int 日常费用_BatchUpdate(List<日常费用ViewModel> models);
        #endregion

        #region 损益表
        [OperationContract]
        List<>
        #endregion
    }
}
