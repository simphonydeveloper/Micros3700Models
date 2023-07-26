using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rvc_status
    {
        public int rvc_seq { get; set; }
        public short? next_chk_num { get; set; }
        public decimal sign_in_key_update_count { get; set; }
    }
}
