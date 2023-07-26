using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tmed_preamble_def
    {
        public int tmed_seq { get; set; }
        public int tmed_preamble_seq { get; set; }
        public string start_preamble { get; set; }
        public string end_preamble { get; set; }
        public short? num_acct_digits { get; set; }
        public int? last_updated_by { get; set; }
    }
}
