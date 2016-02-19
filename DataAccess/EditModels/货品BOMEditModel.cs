using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 货品BOMEditModel
    {
        public string 编码 { get; set; }
        public string 货品信息编码 { get; set; }
        public string 过期时间 { get; set; }
        public string 附加说明 { get; set; }
        public List<BOMDetailViewModel> Details { get; set; }

    }
}
