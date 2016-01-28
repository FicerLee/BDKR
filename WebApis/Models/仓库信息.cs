using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataAccess;

namespace WebApis.Models
{
    public class 仓库信息
    {
        [Key]
        public string 编码 { get; set; }
        [Required]
        public string 仓库名称 { get; set; }
        [Required]
        public string 门店信息编码 { get; set; }
        [Required]
        public string 仓库类别编码 { get; set; }

        public string 附件说明 { get; set; }
        public bool 制品缓冲库 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }
        public virtual 仓库类别 仓库类别 { get; set; }
        public virtual List<采购进货单明细> 采购进货单明细List { get; set; }

        public virtual List<实时库存明细> 实时库存明细List { get; set; }

        internal 仓库ViewModel ConvertToViewModel()
        {
            return new 仓库ViewModel
            {
                仓库名称 = 仓库名称,
                仓库类别名称 = 仓库类别.名称,
                制品缓冲库 = 制品缓冲库,
                编码 = 编码,
                门店名称 = 门店信息.名称
            };
        }
    }
}
