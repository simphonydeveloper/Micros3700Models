using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class interface_def
    {
        public int interface_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? lan_node_seq { get; set; }
        public string msg_interface_name { get; set; }
        public short? num_id_digits { get; set; }
        public short? timeout { get; set; }
        public string ob_log_transactions { get; set; }
        public string type { get; set; }
        public int? com_port_seq { get; set; }
        public string tcp_server_name { get; set; }
        public short? tcp_port_number { get; set; }
        public byte[] sim_script { get; set; }
        public int? pcisn_dev_seq { get; set; }
        public int? cib_dev_seq { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public int? backup_interface_seq { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
