using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_parlevel_dtl
    {
        public int day_of_week { get; set; }
        public int parlevel_seq { get; set; }
        public int cm_item_seq { get; set; }
        public int count_unit_seq { get; set; }
        public int? par_level_value { get; set; }
    }
}
