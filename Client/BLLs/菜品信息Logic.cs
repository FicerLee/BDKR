using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Filters;

namespace Client.BLLs
{
    public class 菜品信息Logic
    {
        internal static object GetList(菜品信息Filter filter)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.菜品信息_GetList(filter);
            }
        }
    }
}
