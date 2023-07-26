using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class vndr_inven_grp_def
    {
        public int vndr_seq { get; set; }
        public int vndr_inven_grp_seq { get; set; }
        public int? inven_cost_grp_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
