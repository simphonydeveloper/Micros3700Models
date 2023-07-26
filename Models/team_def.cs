using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class team_def
    {
        public int store_id { get; set; }
        public int team_seq { get; set; }
        public int team_num { get; set; }
        public string team_name { get; set; }
    }
}
