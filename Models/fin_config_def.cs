using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_config_def
    {
        public int fin_config_seq { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string title_checksum { get; set; }
        public string logo { get; set; }
        public string logo_checksum { get; set; }
        public string actual_style { get; set; }
        public int? actual_color { get; set; }
        public string actual_cnt_style { get; set; }
        public int? actual_cnt_color { get; set; }
        public string budget_style { get; set; }
        public int? budget_color { get; set; }
        public string projected_style { get; set; }
        public int? projected_color { get; set; }
        public string popup { get; set; }
        public int? auto_purge_days { get; set; }
        public string rsvd_01 { get; set; }
        public string rsvd_02 { get; set; }
        public string rsvd_03 { get; set; }
        public string rsvd_04 { get; set; }
        public string ref_rsvd_01 { get; set; }
        public string logo_transparent { get; set; }
        public string send_dir { get; set; }
        public string receive_dir { get; set; }
        public string prd_auto_gen { get; set; }
        public string prd_gen_type { get; set; }
        public int? prd_gen_size { get; set; }
        public int? prd_gen_name_style { get; set; }
        public int? prd_gen_count { get; set; }
        public short? config_type { get; set; }
        public string ob_corporate { get; set; }
    }
}
