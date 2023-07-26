using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dev_temp
    {
        public int dvc_tbl_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string prntr_type { get; set; }
        public string prntr_interface_type { get; set; }
        public int? lan_node_seq { get; set; }
        public short? com_port { get; set; }
        public int? baud_rate { get; set; }
        public short num_data_bits { get; set; }
        public short num_stop_bits { get; set; }
        public string parity_type { get; set; }
        public short? idn_id { get; set; }
        public short? roll_prntr_line_feeds { get; set; }
        public short? prntr_cols { get; set; }
        public string filename { get; set; }
        public string ob_dev01_prn_graphics_avail { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
