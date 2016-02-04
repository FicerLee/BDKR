using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Filters
{
    public class 货品信息Filter : Filter
    {
        public string 货品类别编码 { get; set; }
        public string 门店信息编码 { get; set; }
    }
}
