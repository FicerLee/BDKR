using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 日常费用明细表
    {
        [Key]
        public string 编码 { get; set; }
        public string 日常费用表编码 { get; set; }
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
        public virtual 日常费用表 日常费用表 { get; set; }


    }
}