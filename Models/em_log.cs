using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_log
    {
        public int em_log_seq { get; set; }
        public decimal em_chg_set_seq { get; set; }
        public string table_name { get; set; }
        public string table_type { get; set; }
        public string action_code { get; set; }
        public decimal primary_seq { get; set; }
        public decimal? secondary_seq { get; set; }
        public decimal? tertiary_seq { get; set; }
        public decimal? fourth_seq { get; set; }
        public string primary_col_name { get; set; }
        public string secondary_col_name { get; set; }
        public string tertiary_col_name { get; set; }
        public string fourth_col_name { get; set; }
        public decimal? publication_affected { get; set; }
        public decimal? subscriber_affected { get; set; }
        public string modified_column { get; set; }
        public string old_value { get; set; }
        public string new_value { get; set; }
    }
}
