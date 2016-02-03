using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Filters
{
    public class 费用汇总表Filter : Filter
    {
        public string 门店编码 { get; set; }
        public string 统计年份 { get; set; }
        public string 统计月份 { get; set; }
    }
}
