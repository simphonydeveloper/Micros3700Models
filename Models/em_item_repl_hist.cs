using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_item_repl_hist
    {
        public int? store_id { get; set; }
        public decimal? chg_set_seq { get; set; }
        public string table_name { get; set; }
        public string deactivate { get; set; }
        public decimal? primary_seq { get; set; }
        public decimal? secondary_seq { get; set; }
        public decimal? tertiary_seq { get; set; }
        public decimal? fourth_seq { get; set; }
    }
}
