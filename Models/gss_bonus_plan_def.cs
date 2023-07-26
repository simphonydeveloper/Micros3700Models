using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_bonus_plan_def
    {
        public int bonus_plan_seq { get; set; }
        public string name { get; set; }
        public string is_default { get; set; }
    }
}
