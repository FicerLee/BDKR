using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class 工资表ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _工号;
        private string _员工姓名;
        public string 编码 { get; set; }
        public string 工号
        {
            get
            {
                return _工号;
            }
            set
            {
                if (value != _工号)
                {
                    _工号 = value;
                    OnPropertyChanged("工号");
                }
                else
                    _工号 = value;
            }
        }

        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        public string 员工姓名
        {
            get
            {
                return _员工姓名;
            }
            set
            {
                if (value != _员工姓名)
                {
                    _员工姓名 = value;
                    OnPropertyChanged("员工姓名");
                }
                else
                    _员工姓名 = value;
            }
        }
        public string 职位 { get; set; }
        public decimal 基本工资 { get; set; }
        public decimal 出勤天数 { get; set; }
        public decimal 满勤天数 { get; set; }
        public decimal 出勤工资 => (基本工资 / 满勤天数) * 出勤天数;
        public decimal 绩效 { get; set; }
        public decimal 满勤奖 { get; set; }
        public decimal 迟到早退 { get; set; }
        public decimal 酒水 { get; set; }
        public decimal 其他 { get; set; }
        public decimal 奖励 { get; set; }
        public decimal 补贴 { get; set; }
        public decimal 应发工资 => 出勤工资 + 绩效 + 满勤奖 - 迟到早退 - 酒水 - 其他 + 奖励 + 补贴;
        public decimal 工装返款 { get; set; }
        public decimal 工装扣款 { get; set; }
        public decimal 预支工资 { get; set; }
        public decimal 实发工资 => 应发工资 + 工装返款 - 工装扣款 - 预支工资;

    }
}
