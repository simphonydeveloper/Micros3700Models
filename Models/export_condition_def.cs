using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class export_condition_def
    {
        public int export_seq { get; set; }
        public int export_section_seq { get; set; }
        public int export_condition_seq { get; set; }
        public string column_name { get; set; }
        public string lookup_column { get; set; }
        public string column_display_name { get; set; }
        public string table_name { get; set; }
        public int column_datatype { get; set; }
        public int? param_prompt { get; set; }
        public string creator_name { get; set; }
        public string ob_rsvd01 { get; set; }
        public int? num_rsvd01 { get; set; }
        public string str_rsvd02 { get; set; }
        public string parameter_name { get; set; }
    }
}
