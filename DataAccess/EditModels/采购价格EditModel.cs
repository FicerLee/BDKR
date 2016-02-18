using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 采购价格EditModel
    {
        [Key]
        public string 编码 { get; set; }
        public string 附加说明 { get; set; }
        public string 货品信息编码 { get; set; }
        public decimal 当前采购成本价 { get; set; }
    }
}
