using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Filters
{
    public class 流水账明细Filter : Filter
    {
        public string 门店编码 { get; set; }
        public string 科目编码 { get; set; }
        public string 类别编码 { get; set; }
        public DateTime 记账开始日期 { get; set; }
        public DateTime 记账截止日期 { get; set; }
    }
}
