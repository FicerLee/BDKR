using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 实时库存明细
    {
        [Key]
        public int 编码 { get; set; }
        public string 仓库信息编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 数量 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual 仓库信息 仓库信息 { get; set; }
    }
}
