using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApis.Models
{
    public class 仓库类别
    {
        [Key]
        public string 编码 { get; set; }
        [Required]
        public string 名称 { get; set; }
        public string 附加说明 { get; set; }
        public virtual List<仓库信息> 仓库信息List { get; set; }
    }
}
