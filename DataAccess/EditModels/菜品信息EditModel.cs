using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 菜品信息EditModel
    {
        public string 编码 { get; set; }
        public string 菜品名称 { get; set; }
        public string 菜品类别 { get; set; }
        public string 单位 { get; set; }
        public string 规格 { get; set; }
        public decimal 当前销售价格 { get; set; }
        public string 附加说明 { get; set; }
        public List<BOMDetailViewModel> Details { get; set; }
        public ActionMode Action { get; set; }

    }
}
