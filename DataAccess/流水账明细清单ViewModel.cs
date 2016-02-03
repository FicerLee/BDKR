using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 流水账明细清单ViewModel
    {
        public string 编码 { get; set; }
        public string 流水账清单编码 { get; set; }
        public string 门店编码 { get; set; }
        public string 门店名称 { get; set; }
        public string 记账日期 { get; set; }
        public string 科目 { get; set; }
        public string 类别 { get; set; }
        public string 收入支出 { get; set; }
        public string 消费事由 { get; set; }
        public bool 是否有单据 { get; set; }
        public bool 是否核对 { get; set; }

    }
}
