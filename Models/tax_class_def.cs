using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tax_class_def
    {
        public int tax_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_tax_1_active { get; set; }
        public string ob_tax_2_active { get; set; }
        public string ob_tax_3_active { get; set; }
        public string ob_tax_4_active { get; set; }
        public string ob_tax_5_active { get; set; }
        public string ob_tax_6_active { get; set; }
        public string ob_tax_7_active { get; set; }
        public string ob_tax_8_active { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_rsvd08 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
