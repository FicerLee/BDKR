using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataAccess;

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
        public string 规格 { get; set; }
        public bool 是否菜品 { get; set; }
        public virtual List<货品BOM> 货品BOMList { get; set; }
        public virtual List<货品BOM明细> 货品BOM明细List { get; set; }
        public virtual List<采购成本价格表> 采购价格表List { get; set; }
        public virtual List<销售价格表> 销售价格表List { get; set; }
        public virtual 货品类别 货品类别 { get; set; }
        public virtual List<采购进货单明细> 采购进货单明细List { get; set; }
        public virtual List<实时库存明细> 实时库存List { get; set; }
        public virtual List<菜品销售单明细> 菜品销售单明细List { get; set; }

        internal 货品信息ViewModel ConvertToViewModel()
        {
            return new 货品信息ViewModel
            {
                单位 = 单位,
                最近采购价格 = 采购价格表List == null ? 0 : 采购价格表List.OrderByDescending(t => t.创建时间).Select(t => t.价格).FirstOrDefault(),
                类别名称 = this.货品类别.名称,
                编码 = 编码,
                规格 = 规格,
                货品名称 = 名称
            };
        }

        internal 菜品信息ViewModel ConvertToViewModel_菜品信息()
        {
            var bom = 货品BOMList.FirstOrDefault(t => !t.过期时间.HasValue);
            var details = new List<BOMViewModel>();
            if (null != bom && bom.货品BOM明细List != null)
            {
                bom.货品BOM明细List
                    .ForEach(t =>
                    {
                        details.Add(t.ConvertToViewModel());
                    });
            }
            decimal 当前销售单价 = 0;
            if (销售价格表List != null)
            {
                当前销售单价 = 销售价格表List.OrderByDescending(t => t.创建时间)
                    .Select(t => t.价格)
                    .FirstOrDefault();
            }
            return new 菜品信息ViewModel
            {
                Details = details,
                单位 = 单位,
                当前销售单价 = 当前销售单价,
                编码 = 编码,
                菜品名称 = 名称,
                菜品类别 = 货品类别.名称,
                规格 = 规格
            };
        }
    }
}
