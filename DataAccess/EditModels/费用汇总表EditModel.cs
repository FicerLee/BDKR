using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 费用汇总表EditModel
    {
        [Key]
        public string 编码 { get; set; }
        public int 汇总年份 { get; set; }
        public int 汇总月份 { get; set; }
        public string 制单人编码 { get; set; }
        public List<费用汇总明细表ViewModel> Details { get; set; }
    }
}
