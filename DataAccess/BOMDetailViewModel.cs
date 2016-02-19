using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class BOMDetailViewModel
    {
        public string 编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public string 货品名称 { get; set; }
        public string 规格 { get; set; }
        public string 单位 { get; set; }
        public decimal 单份数量 { get; set; }
    }
}
