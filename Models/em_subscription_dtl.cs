using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_subscription_dtl
    {
        public int subscriber_seq { get; set; }
        public int published_data_seq { get; set; }
        public DateTime? operational_start_date { get; set; }
        public DateTime? operational_end_date { get; set; }
        public int ob_reoccurring { get; set; }
        public int ob_subscription_context { get; set; }
        public int ob_local_control { get; set; }
        public int reference_count { get; set; }
        public int ob_hidden { get; set; }
    }
}
