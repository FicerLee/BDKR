using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 工资表
    {
        [Key]
        public string 编码 { get; set; }
        public string 员工编码 { get; set; }
        public decimal 基本工资 { get; set; }
        public decimal 出勤天数 { get; set; }
        public decimal 绩效工资 { get; set; }
        public decimal 满勤奖 { get; set; }
        public decimal 迟到早退 { get; set; }
        public decimal 酒水 { get; set; }
        public decimal 其他 { get; set; }
        public decimal 奖励 { get; set; }
        public decimal 补贴 { get; set; }
        public decimal 工装返款 { get; set; }
        public decimal 工装扣款 { get; set; }
        public decimal 预支工资 { get; set; }
        public string 附加说明 { get; set; }

        public virtual 员工信息 员工信息 { get; set; }

    }
}