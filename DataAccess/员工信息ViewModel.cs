using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 员工信息ViewModel
    {
        public string 编码 { get; set; }
        public string 姓名 { get; set; }
        public string 工号 { get; set; }
        public decimal 基本工资 { get; set; }
        public string 身份证号 { get; set; }
        public string 联系方式 { get; set; }
        public DateTime 入职日期 { get; set; }

        public string 附加说明 { get; set; }
        public string 门店编码 { get; set; }
        public string 门店 { get; set; }
        public int 工龄 => DateTime.Today.Year - 入职日期.Year;

    }
}
