using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_row_purge_path_cfg
    {
        public string published_data_path { get; set; }
        public int? ob_deploy_optimize { get; set; }
    }
}
