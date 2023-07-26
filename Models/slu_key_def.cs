using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class slu_key_def
    {
        public int slu_key_seq { get; set; }
        public int slu_key_group_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short font { get; set; }
        public short color_combo { get; set; }
        public string icon_placement { get; set; }
        public short? icon_id { get; set; }
        public string legend { get; set; }
        public short? key_type { get; set; }
        public int? key_num { get; set; }
        public string transparent_bitmap { get; set; }
        public string media_file { get; set; }
        public string full_screen { get; set; }
        public string stretch_bitmap { get; set; }
    }
}
