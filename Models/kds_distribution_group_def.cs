using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_distribution_group_def
    {
        public int group_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public int? order_device_mask { get; set; }
    }
}
