using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lm_day_part_weekday_def
    {
        public int day_part_seq { get; set; }
        public short weekday { get; set; }
        public short start_tm { get; set; }
        public int? duration { get; set; }
    }
}
