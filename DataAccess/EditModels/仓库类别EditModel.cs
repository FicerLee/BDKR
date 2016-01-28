using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 仓库类别EditModel
    {
        public string 编码 { get; set; }
        public string 类别名称 { get; set; }
        public string 附加说明 { get; set; }
        public ActionMode Action { get; set; }
    }
}
