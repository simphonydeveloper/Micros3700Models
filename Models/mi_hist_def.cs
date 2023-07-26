using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_hist_def
    {
        public int mi_seq { get; set; }
        public decimal em_chg_set_seq { get; set; }
        public int? old_price_grp_seq { get; set; }
        public int? new_price_grp_seq { get; set; }
    }
}
