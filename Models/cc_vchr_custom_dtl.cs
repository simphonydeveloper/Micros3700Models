using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cc_vchr_custom_dtl
    {
        public int cc_vchr_custom_seq { get; set; }
        public string voucher_data { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
