using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_col_def
    {
        public int infc_col_seq { get; set; }
        public int? infc_record_seq { get; set; }
        public string column_type { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public string prompt_option { get; set; }
        public int? DATATYPE { get; set; }
        public string lookup_col { get; set; }
        public string ob_frgn_key { get; set; }
        public string foreign_tbl_name { get; set; }
        public string primary_tbl_frgn_key_col { get; set; }
        public string frgn_tbl_primary_key_col { get; set; }
        public string creator { get; set; }
        public string tbl_name { get; set; }
        public string col_name { get; set; }
        public string sort_type { get; set; }
        public int? sort_position { get; set; }
        public int? prty_num { get; set; }
    }
}
