using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 菜品销售单
    {
        [Key]
        public string 编码 { get; set; }
        public DateTime 制单日期 { get; set; }
        public DateTime 销售日期 { get; set; }
        public string 制单人编码 { get; set; }
        public string 门店信息编码 { get; set; }
        public string 备注 { get; set; }
        public virtual 用户信息 制单人 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }
        public virtual List<菜品销售单明细> 菜品销售单明细List { get; set; }
    }
}
