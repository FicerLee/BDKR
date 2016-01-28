using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 采购进货单明细
    {
        [Key]
        public string 编码 { get; set; }
        public string 采购进货单号 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 数量 { get; set; }
        public decimal 采购金额 { get; set; }
        public string 仓库信息编码 { get; set; }
        public string 供应商编码 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual 采购进货单 采购进货单 { get; set; }
        public virtual 仓库信息 仓库信息 { get; set; }
        public virtual 供应商信息 供应商信息 { get; set; }
    }
}
