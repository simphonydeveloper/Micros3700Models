using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class export_format_def
    {
        public int export_seq { get; set; }
        public int export_section_seq { get; set; }
        public int export_column_seq { get; set; }
        public string column_name { get; set; }
        public int? column_length { get; set; }
        public string column_justification { get; set; }
        public int? num_decimal_places { get; set; }
        public string ob_suppress_decimal_point { get; set; }
        public string leading_characters { get; set; }
        public string trailing_characters { get; set; }
        public string space_padding_char { get; set; }
        public string ob_use_quotes { get; set; }
        public string quote_character { get; set; }
        public string datetime_format { get; set; }
        public string ob_rsvd01 { get; set; }
        public int? num_rsvd01 { get; set; }
        public string str_rsvd01 { get; set; }
    }
}
