using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 菜品信息ViewModel
    {
        public string 编码 { get; set; }
        public string 菜品名称 { get; set; }
        public string 单位 { get; set; }
        public decimal 当前销售单价 { get; set; }
        public string 菜品类别 { get; set; }
        public List<BOMViewModel> Details { get; set; }

    }
}
