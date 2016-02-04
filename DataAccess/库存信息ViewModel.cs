using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 库存信息ViewModel
    {
        public string 编码 { get; set; }
        public string 货品名称 { get; set; }
        public string 规格 { get; set; }
        public string 单位 { get; set; }
        public string 类别 { get; set; }
        public decimal 当前库存数量 { get; set; }
        public decimal 库存金额 { get; set; }
    }
}
