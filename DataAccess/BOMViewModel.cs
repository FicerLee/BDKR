using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class BOMViewModel
    {
        public string 编码 { get; set; }
        public string 原材料 { get; set; }
        public string 单位 { get; set; }
        public string 规格 { get; set; }
        public int 单份数量 { get; set; }
        public decimal 成本价 { get; set; }
        public string 单份量 => string.Format(@"{0}/{1}", 单份数量, 单位);
    }
}
