using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class peripheral_default_cfg
    {
        public int peripheral_default_cfg_seq { get; set; }
        public string peripheral_type { get; set; }
        public string connection_type { get; set; }
        public string scanner_format_type { get; set; }
        public int? baud_rate { get; set; }
        public string parity_type { get; set; }
        public short? num_data_bits { get; set; }
        public short? num_stop_bits { get; set; }
        public short? scanner_data_string_size { get; set; }
        public short? scanner_data_start_byte { get; set; }
        public short? scanner_data_size { get; set; }
        public string ob_use_default_as_fixed { get; set; }
    }
}
