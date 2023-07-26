using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_table_reg_def
    {
        public int em_table_reg_seq { get; set; }
        public string table_name { get; set; }
        public string logical_table_name { get; set; }
        public string table_type { get; set; }
        public int? em_table_order { get; set; }
        public string sync_direction { get; set; }
        public string item_name_col { get; set; }
        public string table_has_effectivity { get; set; }
        public string not_alterable_after_sent { get; set; }
        public string has_alternate_key { get; set; }
        public string has_grp_or_tier { get; set; }
        public string ob_enterprise_managed { get; set; }
        public int? parent_table_seq { get; set; }
        public string ob_has_lc_definition { get; set; }
        public string publication_method { get; set; }
        public string sync_method { get; set; }
    }
}
