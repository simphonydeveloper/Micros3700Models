using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_bonus_point_multiplier_def
    {
        public int bonus_point_multiplier_seq { get; set; }
        public int bonus_seq { get; set; }
        public short dow { get; set; }
        public short start_hour { get; set; }
        public short end_hour { get; set; }
        public short multiplier { get; set; }
    }
}
