using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataAccess.EditModels
{
    public class 货品信息EditModel : INotifyPropertyChanged
    {
        private string _mc;
        public event PropertyChangedEventHandler PropertyChanged;
        public string 编码 { get; set; }
        public string 货品名称
        {
            get
            {
                return _mc;
            }
            set
            {
                if (value != _mc)
                {
                    _mc = value;
                    OnPropertyChanged("货品名称");
                }
            }
        }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 货品类别 { get; set; }
        public decimal 货品采购成本价 { get; set; }

        public string 附加说明 { get; set; }

        [Display(AutoGenerateField = false)]
        public ActionMode Action { get; set; }

        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
