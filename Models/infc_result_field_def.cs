using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_result_field_def
    {
        public int infc_result_field_seq { get; set; }
        public int? infc_record_seq { get; set; }
        public string name { get; set; }
        public string transformation { get; set; }
        public int? length { get; set; }
        public string justification { get; set; }
        public int? num_decml_places { get; set; }
        public string ob_supress_decml_point { get; set; }
        public string leading_char { get; set; }
        public string trailing_char { get; set; }
        public string space_pad_char { get; set; }
        public string ob_use_quotes { get; set; }
        public string leading_quote_char { get; set; }
        public string trailing_quote_char { get; set; }
        public string datetime_format { get; set; }
    }
}
