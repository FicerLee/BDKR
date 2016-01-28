using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 计量单位
    {
        [Key]
        public string 名称 { get; set; }
        public string 快速访问 { get; set; }
    }
}
