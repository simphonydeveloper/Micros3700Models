using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_line_def
    {
        public int fin_line_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int effective_from_prd { get; set; }
        public int? effective_to_prd { get; set; }
        public string name { get; set; }
        public string cell_ref { get; set; }
        public string actual_source { get; set; }
        public int? actual_source_max { get; set; }
        public string actual_source_def { get; set; }
        public string actual_source_checksum { get; set; }
        public string actual_cnt_source { get; set; }
        public int? actual_cnt_source_max { get; set; }
        public string actual_cnt_source_def { get; set; }
        public string actual_cnt_source_checksum { get; set; }
        public string budget_source { get; set; }
        public int? budget_source_max { get; set; }
        public string budget_source_def { get; set; }
        public string budget_source_checksum { get; set; }
        public string projected_source { get; set; }
        public int? projected_source_max { get; set; }
        public string projected_source_def { get; set; }
        public string projected_source_checksum { get; set; }
        public string ref_id { get; set; }
        public int copy_num { get; set; }
        public string help_text { get; set; }
        public string actual_rsvd_01 { get; set; }
        public string actual_cnt_rsvd_01 { get; set; }
        public string budget_rsvd_01 { get; set; }
        public string projected_rsvd_01 { get; set; }
        public string ref_rsvd_01 { get; set; }
        public int recalc_priority { get; set; }
    }
}
