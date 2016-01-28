using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 货品BOM
    {
        [Key]
        public string 编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public DateTime 更新时间 { get; set; }
        public DateTime? 过期时间 { get; set; }
        public string 备注 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual List<货品BOM明细> 货品BOM明细List { get; set; }
    }
}
