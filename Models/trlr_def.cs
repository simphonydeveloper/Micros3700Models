using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class trlr_def
    {
        public int trlr_seq { get; set; }
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
        public string line_11 { get; set; }
        public string line_12 { get; set; }
        public string ob_print_line_01_red { get; set; }
        public string ob_print_line_02_red { get; set; }
        public string ob_print_line_03_red { get; set; }
        public string ob_print_line_04_red { get; set; }
        public string ob_print_line_05_red { get; set; }
        public string ob_print_line_06_red { get; set; }
        public string ob_print_line_07_red { get; set; }
        public string ob_print_line_08_red { get; set; }
        public string ob_print_line_09_red { get; set; }
        public string ob_print_line_10_red { get; set; }
        public string ob_print_line_11_red { get; set; }
        public string ob_print_line_12_red { get; set; }
        public string ob_print_line_01_wide { get; set; }
        public string ob_print_line_02_wide { get; set; }
        public string ob_print_line_03_wide { get; set; }
        public string ob_print_line_04_wide { get; set; }
        public string ob_print_line_05_wide { get; set; }
        public string ob_print_line_06_wide { get; set; }
        public string ob_print_line_07_wide { get; set; }
        public string ob_print_line_08_wide { get; set; }
        public string ob_print_line_09_wide { get; set; }
        public string ob_print_line_10_wide { get; set; }
        public string ob_print_line_11_wide { get; set; }
        public string ob_print_line_12_wide { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? next_trailer_seq { get; set; }
    }
}
