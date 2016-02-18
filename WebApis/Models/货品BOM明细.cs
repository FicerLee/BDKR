using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataAccess;

namespace WebApis.Models
{
    public class 货品BOM明细
    {
        [Key]
        public string 编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 单份数量 { get; set; }
        public string 单位 { get; set; }
        public string 货品BOM编码 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual 货品BOM 货品BOM { get; set; }

        internal BOMViewModel ConvertToViewModel()
        {
            decimal 最新采购成本 = 0;
            if (货品信息.采购价格表List != null)
                最新采购成本 = 货品信息.采购价格表List
                    .OrderByDescending(t => t.创建时间)
                    .Select(t => t.价格)
                    .FirstOrDefault();
            return new BOMViewModel
            {
                单份数量 = 单份数量,
                单位 = 单位,
                原材料 = 货品信息.名称,
                成本价 = 最新采购成本,
                编码 = 编码,
                规格 = 货品信息.规格
            };
        }
    }
}
