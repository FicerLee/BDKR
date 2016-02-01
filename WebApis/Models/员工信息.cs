using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 员工信息
    {
        public string 工号 { get; set; }
        public string 姓名 { get; set; }
        public string 职位 { get; set; }
        public string 门店编码 { get; set; }
        public decimal 当前基本工资 { get; set; }
        public string 附加说明 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }
    }
}