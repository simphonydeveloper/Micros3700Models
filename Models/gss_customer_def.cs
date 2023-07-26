using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_customer_def
    {
        public int customer_seq { get; set; }
        public int? group_seq { get; set; }
        public DateTime? creation_date { get; set; }
        public string contact_first_name { get; set; }
        public string contact_last_name { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state_or_province { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string contact_title { get; set; }
        public string phone_number_1 { get; set; }
        public string phone_number_2 { get; set; }
        public string phone_number_3 { get; set; }
        public string phone_number_4 { get; set; }
        public string extension { get; set; }
        public string fax_number { get; set; }
        public string email_address { get; set; }
        public DateTime? birthday { get; set; }
        public string notes { get; set; }
        public string active { get; set; }
        public string zone { get; set; }
        public string hoax { get; set; }
        public string card_number { get; set; }
        public string complaints { get; set; }
        public string delivery_notes { get; set; }
        public string courtesy_title { get; set; }
        public string honor { get; set; }
        public string user_defined_1 { get; set; }
        public string user_defined_2 { get; set; }
        public string user_defined_3 { get; set; }
        public string user_defined_4 { get; set; }
        public string user_defined_5 { get; set; }
        public string user_defined_6 { get; set; }
        public string user_defined_7 { get; set; }
        public string user_defined_8 { get; set; }
        public string user_defined_9 { get; set; }
        public string user_defined_10 { get; set; }
        public string cc_card_number { get; set; }
        public string cc_expire_date { get; set; }
        public int? encrypt_value_seq { get; set; }
        public string phone_data_1 { get; set; }
        public string phone_data_2 { get; set; }
        public string phone_data_3 { get; set; }
        public string phone_data_4 { get; set; }
        public string invalid_address { get; set; }
        public string hoax_address { get; set; }
    }
}
