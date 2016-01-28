using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 货品信息ViewModel
    {
        public string 编码 { get; set; }
        public string 货品名称 { get; set; }
        public string 类别名称 { get; set; }
        public string 规格 { get; set; }
        public string 单位 { get; set; }
        public decimal 最近销售价格 { get; set; }
        public decimal 最近采购价格 { get; set; }

    }
}
