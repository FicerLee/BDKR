using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 流水账清单EditModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _年份;
        private int _月份;
        public string 编码 { get; set; }
        public string 附加说明 { get; set; }
        public int 记账年份
        {
            get
            {
                return _年份;
            }
            set
            {
                if (value != _年份)
                {
                    _年份 = value;
                    OnPropertyChanged("年份");
                }
                else
                    _年份 = value;
            }
        }


        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        public int 记账月份
        {
            get
            {
                return _月份;
            }
            set
            {
                if (value != _月份)
                {
                    _月份 = value;
                    OnPropertyChanged("月份");
                }
                else
                    _月份 = value;
            }
        }
        public string 门店编码 { get; set; }
        public List<流水账明细清单ViewModel> Details { get; set; }

    }
}
