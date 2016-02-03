using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 费用汇总表
    {
        [Key]
        public string 编码 { get; set; }
        public string 门店编码 { get; set; }
        public int 汇总年份 { get; set; }
        public int 汇总月份 { get; set; }
        public DateTime 更新时间 { get; set; }
        public string 制单人编码 { get; set; }

        public virtual 门店信息 门店信息 { get; set; }
        public virtual 用户信息 制单人 { get; set; }
        public virtual List<费用汇总明细表> 费用汇总明细表List { get; set; }
    }
}