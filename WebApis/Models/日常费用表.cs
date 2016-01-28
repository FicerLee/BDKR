using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 日常费用表
    {
        [Key]
        public string 编码 { get; set; }
        public string 附加说明 { get; set; }

        public virtual List<日常费用明细表> 日常费用明细List { get; set; }
    }
}