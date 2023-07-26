using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_auto_bonus_level_def
    {
        public int auto_bonus_level_seq { get; set; }
        public string name { get; set; }
        public int bonus_plan_seq { get; set; }
        public decimal? threshold { get; set; }
    }
}
