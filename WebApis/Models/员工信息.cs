using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAccess;
using DataAccess.EditModels;

namespace WebApis.Models
{
    public class 员工信息
    {
        [Key]
        public string 编码 { get; set; }
        public string 工号 { get; set; }
        public string 姓名 { get; set; }
        public string 拼音 { get; set; }
        public string 职位 { get; set; }
        public string 门店编码 { get; set; }
        public decimal 当前基本工资 { get; set; }
        public string 附加说明 { get; set; }
        public string 联系电话 { get; set; }
        public string 身份证号 { get; set; }
        public DateTime 入职日期 { get; set; }
        public virtual 门店信息 门店信息 { get; set; }

        internal 员工信息ViewModel ConvertToViewModel()
        {
            return new 员工信息ViewModel
            {
                入职日期 = 入职日期,
                基本工资 = 当前基本工资,
                姓名 = 姓名,
                工号 = 工号,
                编码 = 编码,
                联系方式 = 联系电话,
                身份证号 = 身份证号,
                门店编码 = 门店编码,
                附加说明 = 附加说明
            };
        }

        internal 员工信息EditModel ConvertToEditModel()
        {
            return new 员工信息EditModel
            {
                入职日期 = 入职日期,
                员工姓名 = 姓名,
                工号 = 工号,
                当前基本工资 = 当前基本工资,
                编码 = 编码,
                职位 = 职位,
                联系电话 = 联系电话,
                身份证号 = 身份证号,
                门店编码 = 门店编码,
                附加说明 = 附加说明
            };
        }
    }
}