using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class uws_option_board_def
    {
        public int uws_seq { get; set; }
        public int option_board_seq { get; set; }
        public short? option_board_type { get; set; }
        public int? cib_dev_seq { get; set; }
        public string ob_cib01_8_digit_ttl_irc { get; set; }
        public string ob_cib02_glb_isn_baud_rate { get; set; }
        public string ob_cib04_port_2_is_rs422 { get; set; }
        public string ob_cib15_suppress_rmt_prompt { get; set; }
        public short? cib_port_1_function { get; set; }
        public short? cib_port_2_function { get; set; }
        public short? pib_port_1_function { get; set; }
        public short? pib_port_2_function { get; set; }
        public int? pib_kybd_terminator { get; set; }
        public short? com_port_1 { get; set; }
        public int? baud_rate_1 { get; set; }
        public short num_stop_bits_1 { get; set; }
        public short num_data_bits_1 { get; set; }
        public string parity_type_1 { get; set; }
        public int? last_updated_by { get; set; }
    }
}
