using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_fcst_mem_def
    {
        public int inven_fcst_mem_seq { get; set; }
        public int inven_fcst_seq { get; set; }
        public int? recipe_seq { get; set; }
        public int ilcg_seq { get; set; }
        public int? fcst_unit_seq { get; set; }
        public short fcst_intervals { get; set; }
        public double? adjustment { get; set; }
        public DateTime? adjmt_date { get; set; }
    }
}
