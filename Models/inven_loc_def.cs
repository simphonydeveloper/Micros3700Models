using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_loc_def
    {
        public int inven_loc_seq { get; set; }
        public int ilcg_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public string ob_dflt { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
