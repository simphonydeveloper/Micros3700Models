using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_published_data_change_dtl
    {
        public int change_dtl_seq { get; set; }
        public string published_data_path { get; set; }
        public int ob_change_type { get; set; }
        public DateTime change_date { get; set; }
        public string subscriber_path { get; set; }
        public string task_id { get; set; }
        public int? validation_flag { get; set; }
    }
}
