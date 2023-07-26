using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lan_node_def
    {
        public int lan_node_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string lan_addr { get; set; }
        public string ob_diskless { get; set; }
        public string type { get; set; }
        public string ip_addr { get; set; }
        public string ip_netmask { get; set; }
        public string gateway_ip_addr { get; set; }
        public string dns_name { get; set; }
        public string dns_ip_addr { get; set; }
        public string mac_addr { get; set; }
        public string boot_file_name { get; set; }
        public string os_product_id { get; set; }
        public string ob_dirty { get; set; }
        public short? resolution { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string workstation_type { get; set; }
        public string ob_override_fp_req { get; set; }
    }
}
