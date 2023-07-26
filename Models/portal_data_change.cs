using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class portal_data_change
    {
        public int header_seq { get; set; }
        public int? dtl_seq { get; set; }
        public int op_type { get; set; }
        public DateTime bus_date { get; set; }
    }
}
