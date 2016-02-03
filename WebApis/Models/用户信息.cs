using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 用户信息
    {
        [Key]
        public string 账号 { get; set; }
        [Required]
        public string 姓名 { get; set; }
        [Required]
        public string 密码 { get; set; }
        public string 备注说明 { get; set; }
        public virtual List<采购进货单> 采购进货单List { get; set; }
        public virtual List<菜品销售单> 菜品销售单List { get; set; }
        public virtual List<收支费用流水明细清单> 收支费用流水明细清单List { get; set; }
        public virtual List<费用汇总表> 费用汇总表List { get; set; }
    }
}
