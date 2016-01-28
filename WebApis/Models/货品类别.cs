using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 货品类别
    {
        [Key]
        public string 编码 { get; set; }
        public string 名称 { get; set; }
        public string 父类编码 { get; set; }
        public string 备注 { get; set; }
        public virtual 货品类别 Parent { get; set; }
        public virtual List<货品类别> Children { get; set; }
        public virtual List<货品信息> 货品信息List { get; set; }
    }
}
