using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class macro_key_def
    {
        public int macro_seq { get; set; }
        public int macro_key_seq { get; set; }
        public short? key_type { get; set; }
        public int? key_num { get; set; }
        public int? last_updated_by { get; set; }
    }
}
