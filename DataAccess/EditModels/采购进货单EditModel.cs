using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 采购进货单EditModel
    {
        public string 编码 { get; set; }
        public DateTime 采购日期 { get; set; } = DateTime.Now;
        public string 制单人编码 { get; set; }
        public string 门店编码 { get; set; }
        public List<采购进货单明细EditModel> Details { get; set; } = new List<采购进货单明细EditModel>();
    }
}
