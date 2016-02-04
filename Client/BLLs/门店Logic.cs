using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.EditModels;

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
                return client.门店信息_GetList();
            }
        }

        internal static void Update(门店EditModel model)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_GetList();
            }
        }

        internal static void Delete(门店EditModel model)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.门店信息_GetList();
            }
        }
    }
}
