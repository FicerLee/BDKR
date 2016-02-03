using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 费用汇总明细表ViewModel
    {
        public string 编码 { get; set; }
        public string 项目名称 { get; set; }
        public string 科目名称 { get; set; }
        public string 类别名称 { get; set; }
        public decimal 金额 { get; set; }
        public string 附加说明 { get; set; }
    }
}
