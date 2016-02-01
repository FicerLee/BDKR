using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 流水科目
    {
        [Key]
        public string 编码 { get; set; }
        public string 名称 { get; set; }
        public string 附加说明 { get; set; }
        public virtual List<收支费用流水明细清单> 收支费用流水明细清单List { get; set; }
    }
}