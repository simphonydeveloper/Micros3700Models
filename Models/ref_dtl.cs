using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ref_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int? parent_trans_seq { get; set; }
        public int? parent_dtl_seq { get; set; }
        [Column("ref")]
        public string ref_2 { get; set; }
        public byte ref_type { get; set; }
        public int? encrypt_value_seq { get; set; }
        public byte[] eAcctNum { get; set; }
    }
}
