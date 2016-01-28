using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class LoginInfoModel
    {
        public string 用户名 { get; set; }
        public string 密码 { get; set; }
        public string 姓名 { get; set; }

        public DateTime 登录时间 { get; set; }
    }
}
