using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 采购成本价格表
    {
        [Key]
        public string 编码 { get; set; }
        public string 货品价格编码 { get; set; }
        public decimal 价格 { get; set; }
        public DateTime 创建时间 { get; set; }
        public string 附加说明 { get; set; }
        public virtual 货品价格 货品价格 { get; set; }


    }
}