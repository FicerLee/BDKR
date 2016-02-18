using DataAccess;
using DataAccess.EditModels;
using DataAccess.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Client.BLLs
{
    public class 仓库Logic
    {
        public static List<仓库ViewModel> GetList(仓库Filter filter = null)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.仓库信息_GetList(filter);
            }
        }

        internal static 仓库EditModel CreateNewEditModel()
        {
            return new 仓库EditModel
            {
                编码 = CreateNewCode(),
                Action = ActionMode.新增
            };
        }

        private static string CreateNewCode()
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                var newcode = client.仓库信息_GetNewCode();
                return newcode;
            }
        }
    }
}
