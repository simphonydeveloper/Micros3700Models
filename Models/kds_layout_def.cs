using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_layout_def
    {
        public int kds_layout_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string style { get; set; }
        public int panel_color { get; set; }
        public int grid_color { get; set; }
        public int selected_color { get; set; }
        public int active_color { get; set; }
        public int app_alert1_color { get; set; }
        public int app_alert2_color { get; set; }
        public int void_color { get; set; }
        public int app_item_color { get; set; }
        public int? title_font_size { get; set; }
        public int? title_font_seq { get; set; }
        public int? row_font_size { get; set; }
        public int? row_font_seq { get; set; }
        public string ob_title_font_bold { get; set; }
        public string ob_row_font_bold { get; set; }
        public string ob_hide_if_same_as_above { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string str_rsvd01 { get; set; }
        public string str_rsvd02 { get; set; }
        public string str_rsvd03 { get; set; }
        public string str_rsvd04 { get; set; }
        public int? num_rsvd01 { get; set; }
        public int? num_rsvd02 { get; set; }
        public int? num_rsvd03 { get; set; }
        public int? num_rsvd04 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
