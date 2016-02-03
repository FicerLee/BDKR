using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 日常费用ViewModel
    {
        public string 编码 { get; set; }
        public string 日常费用表编码 { get; set; }
        public int 统计年度 { get; set; }
        public int 统计月份 { get; set; }
        public decimal 薪资 { get; set; }
        public decimal 劳动保护费 { get; set; }
        public decimal 职工培训费 { get; set; }
        public decimal 职工福利费 { get; set; }
        public decimal 工会经费 { get; set; }
        public decimal 其他费用 { get; set; }
        public decimal 修理费 { get; set; }
        public decimal 物料损耗 { get; set; }
        public decimal 低值易耗品摊销 { get; set; }
        public decimal 水电费 { get; set; }
        public decimal 运输费 { get; set; }
        public decimal 保险费 { get; set; }
        public decimal 试验检验费 { get; set; }
        public decimal 环境保护费 { get; set; }
        public decimal 研究发展费 { get; set; }
        public decimal 燃料费 { get; set; }
        public decimal 交际应酬费 { get; set; }
        public decimal 市场调查费 { get; set; }
        public decimal 文具印刷费 { get; set; }
        public decimal 书报杂志 { get; set; }
        public decimal 差旅费 { get; set; }
        public decimal 交通费 { get; set; }
        public decimal 邮电费 { get; set; }
        public decimal 劳务费 { get; set; }
        public decimal 养路费 { get; set; }
        public decimal 样品费 { get; set; }
        public decimal 其他费用1 { get; set; }
        public decimal 促销费 { get; set; }
        public decimal 广告费 { get; set; }
        public decimal 餐厅租金 { get; set; }
        public decimal 折旧费用 { get; set; }
        public decimal 无形资产摊销 { get; set; }
        public decimal 其他资产摊销 { get; set; }
        public string 附加说明 { get; set; }
        public decimal 人事费用小计 => 薪资 + 劳动保护费 + 职工培训费 + 职工福利费 + 工会经费 + 其他费用;
        public decimal 营运费用小计 => 修理费 + 物料损耗 + 低值易耗品摊销 + 水电费 + 运输费 + 保险费 + 试验检验费 + 环境保护费 + 研究发展费 + 燃料费 + 交际应酬费 + 市场调查费;
        public decimal 行政费用小计 => 文具印刷费 + 书报杂志 + 差旅费 + 交通费 + 邮电费 + 劳务费 + 养路费 + 样品费 + 其他费用1;
        public decimal 促销费用小计 => 促销费;
        public decimal 餐厅费用1小计 => 人事费用小计 + 营运费用小计 + 行政费用小计 + 促销费用小计;
        public decimal 餐厅费用2小计 => 广告费 + 餐厅租金 + 折旧费用 + 无形资产摊销 + 其他资产摊销;
        public decimal 餐厅费用合计 => 餐厅费用1小计 + 餐厅费用2小计;
    }
}
