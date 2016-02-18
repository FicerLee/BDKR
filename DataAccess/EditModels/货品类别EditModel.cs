using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 货品类别EditModel
    {
        public string 编码 { get; set; }
        public string 类别名称 { get; set; }
        public string 备注信息 { get; set; }
        public ActionMode Action { get; set; }
    }
}
