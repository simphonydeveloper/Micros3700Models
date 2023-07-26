using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dirty_inven_trans_dtl
    {
        public int inven_trans_seq { get; set; }
        public DateTime dirty_date { get; set; }
        public int? ilcg_seq { get; set; }
        public DateTime trans_date { get; set; }
        public DateTime bus_date { get; set; }
        public short trans_class { get; set; }
        public int type_seq { get; set; }
    }
}
