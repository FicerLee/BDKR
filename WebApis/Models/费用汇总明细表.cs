using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 费用汇总明细表
    {
        [Key]
        public string 编码 { get; set; }
        public string 汇总表编码 { get; set; }
        public string 项目名称 { get; set; }
        public string 科目名称 { get; set; }
        public string 类别名称 { get; set; }
        public decimal 金额 { get; set; }
        public string 附加说明 { get; set; }
        public virtual 费用汇总表 费用汇总表 { get; set; }

    }
}