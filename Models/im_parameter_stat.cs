using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class im_parameter_stat
    {
        public int store_id { get; set; }
        public decimal? po_next_num { get; set; }
        public DateTime? earliest_mod_date { get; set; }
        public DateTime? portal_data_date { get; set; }
        public string first_time { get; set; }
        public DateTime? portal_reserved_date { get; set; }
        public string portal_reserved_option { get; set; }
    }
}
