using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_avail_def
    {
        public int emp_seq { get; set; }
        public int wk_num { get; set; }
        public short weekday { get; set; }
        public int avail_seq { get; set; }
        public short start_tm { get; set; }
        public int duration { get; set; }
        public short? avail_type { get; set; }
        public int? seg_num { get; set; }
    }
}
