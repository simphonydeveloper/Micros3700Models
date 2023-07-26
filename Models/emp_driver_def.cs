using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_driver_def
    {
        public int emp_seq { get; set; }
        public string license_number { get; set; }
        public string license_state { get; set; }
        public DateTime? license_expire_date { get; set; }
        public string license_name { get; set; }
        public string insurance_co_name { get; set; }
        public string insurance_agent { get; set; }
        public string insurance_policy_num { get; set; }
        public string insurance_policy_type { get; set; }
        public decimal? insurance_coverage { get; set; }
        public DateTime? insurance_expire_date { get; set; }
        public string vehicle_make { get; set; }
        public string vehicle_model { get; set; }
        public string vehicle_year { get; set; }
        public string vehicle_license_plate_num { get; set; }
        public string vehicle_license_state { get; set; }
        public string vehicle_registration_num { get; set; }
        public DateTime? vehicle_registration_expire { get; set; }
        public string vin { get; set; }
    }
}
