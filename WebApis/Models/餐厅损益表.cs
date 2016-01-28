using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 餐厅损益表
    {
        [Key]
        public string 编码 { get; set; }
        public int 年份 { get; set; }
        public int 月份 { get; set; }
        public string 门店编码 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }
        public virtual List<餐厅损益表明细> 餐厅损益表明细List { get; set; }
    }
}