using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kybd_key_def
    {
        public int kybd_seq { get; set; }
        public int key_seq { get; set; }
        public int cfg_sect_ver_seq { get; set; }
        public short? key_type { get; set; }
        public int? key_num { get; set; }
        public string legend { get; set; }
        public string alpha_char { get; set; }
        public int? last_updated_by { get; set; }
    }
}
