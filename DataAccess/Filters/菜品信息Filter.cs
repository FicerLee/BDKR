using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Filters
{
    public class 菜品信息Filter : Filter
    {
        public string 菜品类别编码 { get; set; }
        public decimal 价格区间1 { get; set; }
        public decimal 价格区间2 { get; set; }
    }
}
