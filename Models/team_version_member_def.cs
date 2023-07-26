using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class team_version_member_def
    {
        public int store_id { get; set; }
        public int team_seq { get; set; }
        public int team_version_seq { get; set; }
        public int team_member_seq { get; set; }
        public decimal allocation_percent { get; set; }
    }
}
