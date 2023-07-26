using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class srm_ref_dtl
    {
        public int? chk_seq { get; set; }
        public short chk_num { get; set; }
        public DateTime date_tm { get; set; }
        public decimal ttl_before_tax { get; set; }
        public string prev_trans { get; set; }
        public string prev_ref { get; set; }
        public byte[] seat_map { get; set; }
        public string seat_zero { get; set; }
        public int? order_type_seq { get; set; }
        public short? num_dtl { get; set; }
    }
}
