using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public int mi_seq { get; set; }
        public string ob_dtl04_rtn { get; set; }
        public string ob_dtl21_bev_aft_prompt { get; set; }
        public short? crs { get; set; }
        public string ob_tax_1_active { get; set; }
        public string ob_tax_2_active { get; set; }
        public string ob_tax_3_active { get; set; }
        public string ob_tax_4_active { get; set; }
        public string ob_tax_5_active { get; set; }
        public string ob_tax_6_active { get; set; }
        public string ob_tax_7_active { get; set; }
        public string ob_tax_8_active { get; set; }
        public string ob_modified_by_no { get; set; }
        public int sls_itmzr_seq { get; set; }
        public short price_lvl { get; set; }
        public byte[] type_def { get; set; }
        public short dsc_itmzr { get; set; }
        public short svc_itmzr { get; set; }
        public short print_grp { get; set; }
        public decimal? surcharge_tax_ttl { get; set; }
        public decimal? item_weight { get; set; }
        public string combo_meal_num { get; set; }
        public int? combo_side_num { get; set; }
        public decimal? vat_txbl_amt { get; set; }
        public int? combo_grp_seq { get; set; }
        public int? cndmnt_grp { get; set; }
        public short? price_lvl_original { get; set; }
        public int? refill_dtl_id { get; set; }
        public decimal? refill_base_price { get; set; }
        public int? print_class_seq { get; set; }
        public int? dining_course_seq { get; set; }
        public int? combo_size { get; set; }
        public decimal? inclusive_tax_ttl_forgiven { get; set; }
        public int? om_type { get; set; }
        public int? om_number { get; set; }
        public int? om_base_seq { get; set; }
        public int? om_section_info_seq { get; set; }
        public int? om_specialty_seq { get; set; }
        public int? om_topping_seq { get; set; }
        public int? om_topping_mi_seq { get; set; }
        public int? om_modifier_seq { get; set; }
        public int? parent_dtl_seq { get; set; }
        public string ob_is_condiment { get; set; }
        public int? return_dtl_id { get; set; }
        public short? prefix_type { get; set; }
        public short? prefix_override_level { get; set; }
        public int? maj_grp_seq { get; set; }
        public int? fam_grp_seq { get; set; }
        public int? obj_num { get; set; }
        public int? source_slu_seq { get; set; }
        public int? participant_id_01 { get; set; }
        public int? participant_id_02 { get; set; }
        public int? participant_id_03 { get; set; }
        public int? participant_id_04 { get; set; }
        public int? participant_id_05 { get; set; }
        public int? participant_id_06 { get; set; }
        public int? participant_id_07 { get; set; }
        public int? participant_id_08 { get; set; }
        public decimal? combo_meal_savings_ttl { get; set; }
        public int? group_dtl_id { get; set; }
        public int? prep_time_modified { get; set; }
    }
}
