using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 供应商信息
    {
        [Key]
        public string 编码 { get; set; }
        [Required]
        public string 名称 { get; set; }
        public string 联系电话 { get; set; }
        public string 地址 { get; set; }
        public string 备注 { get; set; }
        public virtual List<采购进货单> 采购进货单List { get; set; }
    }
}
