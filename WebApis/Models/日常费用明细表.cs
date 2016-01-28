using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 日常费用明细表
    {
        [Key]
        public string 编码 { get; set; }
        public string 日常费用表编码 { get; set; }

        public virtual 日常费用表 日常费用表 { get; set; }
    }
}