using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 损益表ViewModel
    {
        public string 编码 { get; set; }
        public decimal 销售收入 { get; set; }
        public decimal 营业税金 { get; set; }
        public decimal 销售成本 { get; set; }
        public decimal 人事费用 { get; set; }
        public decimal 营运费用 { get; set; }
        public decimal 行政费用 { get; set; }
        public decimal 折旧费用 { get; set; }
        public decimal 促销费用 { get; set; }
        public decimal 广告费用 { get; set; }
        public decimal 餐厅资金 { get; set; }
        public decimal 其他摊提 { get; set; }
        public decimal 其他业务收入 { get; set; }
        public decimal 其他业务支出 { get; set; }
        public decimal 销售净额 => 销售收入 - 营业税金;
        public decimal 销售毛利 => 销售净额 - 销售成本;
        public decimal 餐厅费用小计1 => 人事费用 + 营运费用 + 行政费用 + 促销费用;
        public decimal 可控制利益 => 销售毛利 - 餐厅费用小计1;
        public decimal 餐厅费用小计2 => 广告费用 + 餐厅资金 + 折旧费用 + 其他摊提;
        public decimal 主营业务利益 => 可控制利益 - 餐厅费用小计2;
        public decimal 餐厅利益 => 主营业务利益 + 其他业务收入 - 其他业务支出;
        public decimal 现金贡献 => 折旧费用 + 其他摊提 + 餐厅利益;

    }
}
