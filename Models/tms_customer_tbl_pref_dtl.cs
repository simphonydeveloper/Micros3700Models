using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_customer_tbl_pref_dtl
    {
        public int customer_tbl_pref_dtl_seq { get; set; }
        public int customer_seq { get; set; }
        public int tbl_prop_value_seq { get; set; }
    }
}
