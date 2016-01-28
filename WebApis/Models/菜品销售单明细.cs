using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 菜品销售单明细
    {
        [Key]
        public string 编码 { get; set; }
        public string 菜品销售单编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 数量 { get; set; }
        public decimal 销售单价 { get; set; }
        public decimal 实际销售金额 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual 菜品销售单 菜品销售单 { get; set; }
    }
}
