using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class acctng_prd_grp_def
    {
        public short acctng_prd_grp_seq { get; set; }
        public int acctng_year_seq { get; set; }
        public string name { get; set; }
        public int begin_acctng_prd_seq { get; set; }
        public int end_acctng_prd_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
