using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_def
    {
        public int recipe_seq { get; set; }
        public string name_1 { get; set; }
        public string upper_name_1 { get; set; }
        public string name_2 { get; set; }
        public int obj_num { get; set; }
        public string recipe_type { get; set; }
        public string photo_image { get; set; }
        public double? batch_amt { get; set; }
        public int? batch_size_unit_seq { get; set; }
        public int? portion_size_unit_seq { get; set; }
        public double? additional_cost_amt { get; set; }
        public double? std_cost_amt { get; set; }
        public double? high_cost_allowed_amt { get; set; }
        public double? high_cost_allowed_pct { get; set; }
        public string prod_cmnt { get; set; }
        public string prod_video { get; set; }
        public string srv_instruction_cmnt { get; set; }
        public string srv_video { get; set; }
        public short? srv_minute { get; set; }
        public short? srv_hrs { get; set; }
        public double? srv_size { get; set; }
        public double? num_srv { get; set; }
        public int? calorie { get; set; }
        public string recipe_desc_cmnt { get; set; }
        public string ob_use_density_fctr { get; set; }
        public double? density_fctr_vol { get; set; }
        public double? density_fctr_wght { get; set; }
        public double? density_fctr { get; set; }
        public short? prod_lab_hrs { get; set; }
        public short? prod_lab_minute { get; set; }
        public short? shelf_life_hrs { get; set; }
        public short? shelf_life_day { get; set; }
        public string third_party_xref_id { get; set; }
        public int? density_fctr_wght_unit_seq { get; set; }
        public int? srv_unit_seq { get; set; }
        public int? density_fctr_vol_unit_seq { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
        public short ovrde_costing_mthd { get; set; }
        public double? std_cost_pctge { get; set; }
        public string recipe_book_pg_num { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_req_ilcg { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
