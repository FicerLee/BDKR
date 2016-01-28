using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
