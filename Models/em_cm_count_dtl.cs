using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_count_dtl
    {
        public int store_id { get; set; }
        public int receptacle_seq { get; set; }
        public int count_seq { get; set; }
        public string countsheet_name { get; set; }
        public int countsheet_layout_version { get; set; }
        public DateTime count_start_time { get; set; }
    }
}
