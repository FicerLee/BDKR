using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Filters;

namespace Client.BLLs
{
    public class 员工信息Logic
    {
        internal static object GetList(员工信息Filter filter)
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.员工信息_GetList(filter);
            }
        }
    }
}
