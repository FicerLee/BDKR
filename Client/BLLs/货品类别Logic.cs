using DataAccess.EditModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.BLLs
{
    public class 货品类别Logic
    {
        public static List<货品类别ViewModel> GetList()
        {
            using (var client = new BDKRWS.BDKRWSClient())
            {
                return client.货品类别_GetList();
            }
        }
    }
}
