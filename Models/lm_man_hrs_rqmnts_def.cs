using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_man_hrs_rqmnts_def
    {
        public int man_hrs_rule_seq { get; set; }
        public int man_hrs_rqmnt_seq { get; set; }
        public decimal start_sales_base { get; set; }
        public decimal end_sales_base { get; set; }
        public decimal lab_prod_index { get; set; }
    }
}
