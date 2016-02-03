using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Filters
{
    public class 工资表Filter : Filter
    {
        public string 门店编码 { get; set; }
        public int 开始年份 { get; set; }
        public int 开始月份 { get; set; }
        public int 结束年份 { get; set; }
        public int 结束月份 { get; set; }
    }
}
