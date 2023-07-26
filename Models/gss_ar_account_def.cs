using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_account_def
    {
        public int ar_account_seq { get; set; }
        public int? group_seq { get; set; }
        public int? ar_terms_seq { get; set; }
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
        public string phone_number { get; set; }
        public string extension { get; set; }
        public string fax_number { get; set; }
        public string email_address { get; set; }
        public string notes { get; set; }
        public decimal? credit_limit { get; set; }
        public string credit_hold { get; set; }
        public string pre_paid { get; set; }
        public string card_number { get; set; }
        public DateTime? expire_date { get; set; }
        public string description { get; set; }
        public string tax_id { get; set; }
    }
}
