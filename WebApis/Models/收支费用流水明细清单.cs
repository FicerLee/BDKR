using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 收支费用流水明细清单
    {
        [Key]
        public string 编码 { get; set; }
        public string 收支费用流水清单编码 { get; set; }
        public DateTime 记账日期 { get; set; }
        public DateTime 更新日期 { get; set; }
        public string 流水科目编码 { get; set; }
        public string 流水类别编码 { get; set; }
        public decimal 收支金额 { get; set; }
        public string 消费事由 { get; set; }
        public bool 是否有单据 { get; set; }
        public bool 是否核对 { get; set; }
        public string 附加说明 { get; set; }
        public string 制单员编码 { get; set; }

        public virtual 收支费用流水清单 收支费用流水清单 { get; set; }
        public virtual 流水科目 科目 { get; set; }
        public virtual 流水类别 类别 { get; set; }
        public virtual 用户信息 制单员 { get; set; }
    }
}