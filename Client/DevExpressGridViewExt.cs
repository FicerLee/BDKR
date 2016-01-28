using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public static class DevExpressGridViewExt
    {
        public static void AutoConfig(this GridView gv, GridViewConfig config = null)
        {
            if (null == config)
                config = new GridViewConfig();
            gv.OptionsBehavior.AutoPopulateColumns = config.AutoPopulateColumns;
            gv.OptionsBehavior.Editable = config.Editable;
            gv.OptionsView.ColumnAutoWidth = config.ColumnAutoWidth;
            gv.OptionsView.EnableAppearanceEvenRow = config.EnableAppearanceEvenRow;
            gv.OptionsView.EnableAppearanceOddRow = config.EnableAppearanceOddRow;
            gv.RowHeight = config.RowHeight;
        }
    }

    public class GridViewConfig
    {
        public bool Editable { get; set; } = false;
        public bool ColumnAutoWidth { get; set; } = false;
        public bool EnableAppearanceEvenRow { get; set; } = true;
        public bool EnableAppearanceOddRow { get; set; } = true;
        public int RowHeight { get; set; } = 25;
        public bool AutoPopulateColumns = false;
    }
}
