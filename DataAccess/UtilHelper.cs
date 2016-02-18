using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class UtilHelper
    {
        public static string PinYin(string str)
        {
            var arr = str.ToArray();
            var _str = "";
            var format = new Pinyin4net.Format.HanyuPinyinOutputFormat();
            format.CaseType = Pinyin4net.Format.HanyuPinyinCaseType.LOWERCASE;
            format.ToneType = Pinyin4net.Format.HanyuPinyinToneType.WITHOUT_TONE;
            arr.ToList()
                .ForEach(t =>
                {
                    var _arr = Pinyin4net.PinyinHelper.ToHanyuPinyinStringArray(t, format);
                    if (_arr != null)
                    {
                        _arr
                        .ToList()
                        .ForEach(u =>
                        {
                            _str += u;
                        });
                    }
                });
            return _str;
        }
    }
}
