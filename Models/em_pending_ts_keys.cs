using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_pending_ts_keys
    {
        public int ts_scrn_seq { get; set; }
        public int ts_key_seq { get; set; }
        public int cfg_sect_ver_seq { get; set; }
        public short? ts_id { get; set; }
        public short? row_start { get; set; }
        public short? col_start { get; set; }
        public short? height { get; set; }
        public short? width { get; set; }
        public short font { get; set; }
        public short color_combo { get; set; }
        public string icon_placement { get; set; }
        public short? icon_id { get; set; }
        public string legend { get; set; }
        public short? key_type { get; set; }
        public int? key_num { get; set; }
        public int? next { get; set; }
        public int? last_updated_by { get; set; }
        public string ob_geometry_locked { get; set; }
        public string ob_attribute_locked { get; set; }
        public string transparent_bitmap { get; set; }
        public string media_file { get; set; }
        public string full_screen { get; set; }
        public string stretch_bitmap { get; set; }
    }
}
