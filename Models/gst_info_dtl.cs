using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gst_info_dtl
    {
        public int chk_seq { get; set; }
        public short seat { get; set; }
        public int customer_seq { get; set; }
        public short? num_guest_lines { get; set; }
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
        public string line_13 { get; set; }
        public string line_14 { get; set; }
        public string line_15 { get; set; }
        public string line_16 { get; set; }
        public string delivery_format { get; set; }
    }
}
