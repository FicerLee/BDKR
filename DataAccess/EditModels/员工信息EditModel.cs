using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 员工信息EditModel
    {
        public string 编码 { get; set; }
        public string 员工姓名 { get; set; }
        public string 工号 { get; set; }
        public string 职位 { get; set; }
        public string 门店编码 { get; set; }
        public decimal 当前基本工资 { get; set; }
        public string 附加说明 { get; set; }
        public string 联系电话 { get; set; }
        public string 身份证号 { get; set; }
        public DateTime 入职日期 { get; set; }
    }
}
