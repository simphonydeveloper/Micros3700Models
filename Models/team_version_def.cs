using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class team_version_def
    {
        public int store_id { get; set; }
        public int team_seq { get; set; }
        public int team_version_seq { get; set; }
        public DateTime? begin_time { get; set; }
        public DateTime? end_time { get; set; }
        public int? modified_by { get; set; }
    }
}
