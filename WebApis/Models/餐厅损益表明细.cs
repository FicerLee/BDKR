using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 餐厅损益表明细
    {
        [Key]
        public string 编码 { get; set; }
        public string 餐厅损益表编码 { get; set; }
        public decimal 销售收入 { get; set; }
        public decimal 营业税金 { get; set; }
        public decimal 折旧费用 { get; set; }
        public decimal 销售成本 { get; set; }
        public decimal 人事费用 { get; set; }
        public decimal 营运费用 { get; set; }
        public decimal 行政费用 { get; set; }
        public decimal 促销费用 { get; set; }
        public decimal 广告费用 { get; set; }
        public decimal 餐厅资金 { get; set; }
        public decimal 其他摊提 { get; set; }
        public decimal 其他业务收入 { get; set; }
        public decimal 其他业务支出 { get; set; }
        public string 附加说明 { get; set; }

        public virtual 餐厅损益表 餐厅损益表 { get; set; }
    }
}