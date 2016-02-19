using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.EditModels;
using System.Linq.Expressions;

namespace Client.BLLs
{
    public class 门店Logic
    {
        public static List<门店ViewModel> GetList()
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_GetList();
            }
        }

        internal static void AddNew(门店EditModel model)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                client.门店信息_AddNew(model);
            }
        }

        internal static void Update(门店EditModel model)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                client.门店信息_Update(model);
            }
        }

        internal static string GetNewCode()
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_GetNewCode();
            }
        }

        internal static void Delete(string 门店信息编码)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                client.门店信息_Delete(门店信息编码);
            }
        }

        internal static 门店EditModel GetEditModel(string code)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_GetEditModelById(code);
            }
        }

        internal static int Remove(string 编码)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_Delete(编码);
            }
        }
    }
}
