using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_table_sync_def
    {
        public int store_id { get; set; }
        public int em_table_reg_seq { get; set; }
        public string active_flag { get; set; }
        public string ob_filter_lc_on_sync { get; set; }
    }
}
