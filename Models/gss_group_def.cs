using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_group_def
    {
        public int group_seq { get; set; }
        public string group_name { get; set; }
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
        public string active { get; set; }
    }
}
