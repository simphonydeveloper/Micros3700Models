using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class work_hrs_seg_def
    {
        public int work_hrs_seq { get; set; }
        public int work_hrs_seg_seq { get; set; }
        public short weekday { get; set; }
        public short start_tm { get; set; }
        public int? duration { get; set; }
    }
}
