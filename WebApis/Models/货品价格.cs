using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApis.Models
{
    public class 货品价格
    {
        public string 编码 { get; set; }
        public string 附加说明 { get; set; }
        public virtual 货品信息 货品信息 { get; set; }
        public virtual List<销售价格表> 销售价格表List { get; set; }
        public virtual List<采购成本价格表> 采购价格表List { get; set; }


    }
}