using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_chg_set_def
    {
        public decimal em_chg_set_seq { get; set; }
        public int store_id { get; set; }
        public DateTime? store_ovrrd_effective_from { get; set; }
        public DateTime? store_ovrrd_effective_to { get; set; }
    }
}
