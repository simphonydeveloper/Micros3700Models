using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class uws_peripheral_def
    {
        public int uws_seq { get; set; }
        public int uws_peripheral_seq { get; set; }
        public string peripheral_type { get; set; }
        public string connection_type { get; set; }
        public string opos_cfg_string { get; set; }
        public int? lan_node_seq { get; set; }
        public int? com_port_seq { get; set; }
        public string scanner_format_type_1 { get; set; }
        public short? scanner_data_string_size_1 { get; set; }
        public short? scanner_data_start_byte_1 { get; set; }
        public short? scanner_data_size_1 { get; set; }
        public string scanner_format_type_2 { get; set; }
        public short? scanner_data_string_size_2 { get; set; }
        public short? scanner_data_start_byte_2 { get; set; }
        public short? scanner_data_size_2 { get; set; }
        public string ob_opos_option_1 { get; set; }
        public string ob_opos_option_2 { get; set; }
        public string ob_opos_option_3 { get; set; }
        public string ob_opos_option_4 { get; set; }
        public string ob_opos_option_5 { get; set; }
        public string ob_opos_option_6 { get; set; }
        public string ob_opos_option_7 { get; set; }
        public string ob_opos_option_8 { get; set; }
        public int? last_updated_by { get; set; }
        public string periph_ip_address { get; set; }
        public string periph_port_number { get; set; }
        public string uws_port_number { get; set; }
        public int? lane_number { get; set; }
    }
}
