using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 仓库EditModel
    {
        public string 编码 { get; set; }
        public string 仓库名称 { get; set; }
        public string 类别编码 { get; set; }
        public string 门店编码 { get; set; }
        public string 附加说明 { get; set; }
        public bool 制品缓冲库 { get; set; }
        public ActionMode Action { get; set; }
    }
}
