using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class info_screen_def
    {
        public int info_scrn_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string line_01 { get; set; }
        public string line_02 { get; set; }
        public string line_03 { get; set; }
        public string line_04 { get; set; }
        public string line_05 { get; set; }
        public string line_06 { get; set; }
        public string line_07 { get; set; }
        public string line_08 { get; set; }
        public string line_09 { get; set; }
        public string line_10 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
