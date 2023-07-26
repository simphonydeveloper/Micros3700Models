using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hdr_def
    {
        public int hdr_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string line_01 { get; set; }
        public string line_02 { get; set; }
        public string line_03 { get; set; }
        public string line_04 { get; set; }
        public string line_05 { get; set; }
        public string line_06 { get; set; }
        public string ob_print_line_01_red { get; set; }
        public string ob_print_line_02_red { get; set; }
        public string ob_print_line_03_red { get; set; }
        public string ob_print_line_04_red { get; set; }
        public string ob_print_line_05_red { get; set; }
        public string ob_print_line_06_red { get; set; }
        public string ob_print_line_01_wide { get; set; }
        public string ob_print_line_02_wide { get; set; }
        public string ob_print_line_03_wide { get; set; }
        public string ob_print_line_04_wide { get; set; }
        public string ob_print_line_05_wide { get; set; }
        public string ob_print_line_06_wide { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
