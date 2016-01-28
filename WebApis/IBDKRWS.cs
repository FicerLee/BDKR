using DataAccess;
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

        #endregion

        #region 仓库
        [OperationContract]
        List<仓库ViewModel> 仓库信息_GetList(仓库Filter filter);
        [OperationContract]
        string 仓库信息_CreateNewCode();
        #endregion

    }
}
