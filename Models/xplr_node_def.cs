using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xplr_node_def
    {
        public int node_seq { get; set; }
        public short node_type { get; set; }
        public int? par_node_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public short? icon_id { get; set; }
        public short? access_type { get; set; }
        public string parm { get; set; }
        public int? created_by { get; set; }
        public DateTime created_date { get; set; }
        public int? last_mod_by { get; set; }
        public DateTime? last_mod_date { get; set; }
    }
}
