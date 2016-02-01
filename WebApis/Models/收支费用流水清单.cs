using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 收支费用流水清单
    {
        [Key]
        public string 编码 { get; set; }
        public string 附加说明 { get; set; }
        public string 门店编码 { get; set; }
        public int 记账年份 { get; set; }
        public int 记账月份 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }
        public virtual List<收支费用流水明细清单> 收支费用流水明细清单List { get; set; }
    }
}