using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_restaurant_def
    {
        public int restaurant_seq { get; set; }
        public string contact_first_name { get; set; }
        public string contact_last_name { get; set; }
        public string phone_mask { get; set; }
        public string fax_number { get; set; }
        public string payable_to { get; set; }
        public int order_totals_to_keep { get; set; }
        public int order_details_to_keep { get; set; }
        public string print_gift_cert_on_roll { get; set; }
        public string caller_id_server { get; set; }
        public int? card_number_track { get; set; }
        public int? card_number_start { get; set; }
        public int? card_number_len { get; set; }
        public int? gift_card_number_track { get; set; }
        public int? gift_card_number_start { get; set; }
        public int? gift_card_number_len { get; set; }
        public string prompt_delivery_time { get; set; }
        public string check_info_line_1 { get; set; }
        public string check_info_line_2 { get; set; }
        public string check_info_line_3 { get; set; }
        public string check_info_line_4 { get; set; }
        public string check_info_line_5 { get; set; }
        public string check_info_line_6 { get; set; }
        public string check_info_line_7 { get; set; }
        public string check_info_line_8 { get; set; }
        public string check_info_line_9 { get; set; }
        public string check_info_line_10 { get; set; }
        public string check_info_line_11 { get; set; }
        public string check_info_line_12 { get; set; }
        public string check_info_line_13 { get; set; }
        public string check_info_line_14 { get; set; }
        public string check_info_line_15 { get; set; }
        public string check_info_line_16 { get; set; }
        public string del_check_info_line_1 { get; set; }
        public string del_check_info_line_2 { get; set; }
        public string del_check_info_line_3 { get; set; }
        public string del_check_info_line_4 { get; set; }
        public string del_check_info_line_5 { get; set; }
        public string del_check_info_line_6 { get; set; }
        public string del_check_info_line_7 { get; set; }
        public string del_check_info_line_8 { get; set; }
        public string del_check_info_line_9 { get; set; }
        public string del_check_info_line_10 { get; set; }
        public string del_check_info_line_11 { get; set; }
        public string del_check_info_line_12 { get; set; }
        public string del_check_info_line_13 { get; set; }
        public string del_check_info_line_14 { get; set; }
        public string del_check_info_line_15 { get; set; }
        public string del_check_info_line_16 { get; set; }
        public string delivery_check_zones { get; set; }
        public string delivery_check_blocks { get; set; }
        public string customer_name_in_chk_id { get; set; }
        public int? delivery_time { get; set; }
        public string require_cc_on_file { get; set; }
        public string charge_description { get; set; }
        public int? charge_gl_account_seq { get; set; }
        public string interest_description { get; set; }
        public int? interest_gl_account_seq { get; set; }
        public string batch_template { get; set; }
        public string invoice_template { get; set; }
        public int invoices_to_keep { get; set; }
        public string user_defined_text01 { get; set; }
        public string user_defined_text02 { get; set; }
        public string user_defined_text03 { get; set; }
        public string user_defined_text04 { get; set; }
        public string user_defined_text05 { get; set; }
        public string user_defined_text06 { get; set; }
        public string user_defined_text07 { get; set; }
        public string user_defined_text08 { get; set; }
        public string user_defined_text09 { get; set; }
        public string user_defined_text10 { get; set; }
        public string postal_code_recognition { get; set; }
        public int? retain_inactive_customer_days { get; set; }
        public string back_office_use_delivery { get; set; }
        public string name { get; set; }
        public string enabled { get; set; }
        public string postal_expression { get; set; }
        public string address_display_format { get; set; }
        public string hoax_addr_validation { get; set; }
    }
}
