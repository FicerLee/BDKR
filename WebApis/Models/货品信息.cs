using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 货品信息
    {
        [Key]
        public string 编码 { get; set; }
        public string 名称 { get; set; }
        public string 货品类别编码 { get; set; }
        public string 拼音 { get; set; }
        public string 备注 { get; set; }
        public string 单位 { get; set; }

        public string 货品价格编码 { get; set; }
        public virtual List<货品BOM> 货品BOMList { get; set; }
        public virtual List<货品BOM明细> 货品BOM明细List { get; set; }
        public virtual 货品价格 货品价格 { get; set; }
        public virtual 货品类别 货品类别 { get; set; }
        public virtual List<采购进货单明细> 采购进货单明细List { get; set; }
        public virtual List<实时库存明细> 实时库存List { get; set; }
        public virtual List<菜品销售单明细> 菜品销售单明细List { get; set; }
    }
}
