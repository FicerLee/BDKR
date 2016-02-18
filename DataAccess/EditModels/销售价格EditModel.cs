using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 销售价格EditModel
    {
        public string 编码 { get; set; }
        public decimal 当前销售价格 { get; set; }
        public string 货品信息编码 { get; set; }
        public string 附加说明 { get; set; }
    }
}
