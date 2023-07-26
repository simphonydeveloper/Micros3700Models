using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class com_port_def
    {
        public int lan_node_seq { get; set; }
        public int com_port_seq { get; set; }
        public short com_port { get; set; }
        public int? baud_rate { get; set; }
        public short num_data_bits { get; set; }
        public short num_stop_bits { get; set; }
        public string parity_type { get; set; }
        public int? last_updated_by { get; set; }
    }
}
