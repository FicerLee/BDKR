using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataAccess.EditModels;

namespace WebApis.Models
{
    public class 门店信息
    {
        [Key]
        public string 编码 { get; set; }
        public string 名称 { get; set; }
        public string 地址 { get; set; }
        public string 联系电话 { get; set; }
        public string 备注 { get; set; }
        public string 店长 { get; set; }
        public virtual List<仓库信息> 仓库信息List { get; set; }
        public virtual List<采购进货单> 采购进货单List { get; set; }
        public virtual List<实时库存明细> 实时库存明细List { get; set; }
        public virtual List<菜品销售单> 菜品销售单List { get; set; }
        public virtual List<餐厅损益表> 餐厅损益表List { get; set; }
        public virtual List<收支费用流水清单> 收支费用流水清单List { get; set; }
        public virtual List<员工信息> 员工信息List { get; set; }
        public virtual List<日常费用明细表> 日常费用明细表List { get; set; }
        public virtual List<费用汇总表> 费用汇总表List { get; set; }

        internal 门店ViewModel ConvertToViewModel()
        {
            return new 门店ViewModel
            {
                店长 = 店长,
                编码 = 编码,
                联系电话 = 联系电话,
                门店名称 = 名称,
                门店地址 = 地址
            };
        }

        internal 门店EditModel ConvertToEditModel()
        {
            return new 门店EditModel
            {
                店长 = 店长,
                编码 = 编码,
                联系电话 = 联系电话,
                门店名称 = 名称,
                门店地址 = 地址,
                附加说明 = 备注
            };
        }
    }
}
