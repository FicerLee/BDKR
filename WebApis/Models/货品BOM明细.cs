using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 货品BOM明细
    {
        [Key]
        public string 编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 单份数量 { get; set; }
        public string 单位 { get; set; }
        public string 货品BOM编码 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual 货品BOM 货品BOM { get; set; }
    }
}
