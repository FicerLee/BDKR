using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataAccess.EditModels;

namespace WebApis.Models
{
    public class 货品类别
    {
        [Key]
        public string 编码 { get; set; }
        public string 名称 { get; set; }
        public string 备注 { get; set; }
        public virtual List<货品信息> 货品信息List { get; set; }

        internal 货品类别ViewModel ConvertToViewModel()
        {
            return new 货品类别ViewModel
            {
                编码 = 编码,
                类别名称 = 名称
            };
        }
    }
}
