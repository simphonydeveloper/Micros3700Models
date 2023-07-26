using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_published_data_def
    {
        public int published_data_seq { get; set; }
        public string published_data_path { get; set; }
        public int default_ob_reoccurring { get; set; }
        public int default_ob_local_control { get; set; }
    }
}
