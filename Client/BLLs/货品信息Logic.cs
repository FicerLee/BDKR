using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Filters;
using DataAccess;

namespace Client.BLLs
{
    public class 货品信息Logic
    {
        internal static List<货品信息ViewModel> GetList(货品信息Filter filter)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.货品信息_GetList(filter);
            }
        }
    }
}
