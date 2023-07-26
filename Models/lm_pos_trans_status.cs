using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_pos_trans_status
    {
        public int pos_trans_seq { get; set; }
        public string trans_item_desc { get; set; }
        public int? last_trans_seq { get; set; }
        public DateTime? last_trans_seq_date { get; set; }
    }
}
