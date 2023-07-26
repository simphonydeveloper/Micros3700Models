using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class db_version_cfg
    {
        public int db_version_seq { get; set; }
        public string db_module { get; set; }
        public string db_module_desc { get; set; }
        public int db_build_num { get; set; }
        public DateTime db_build_date { get; set; }
        public int? db_service_pak_num { get; set; }
        public string db_service_pak_desc { get; set; }
        public DateTime? installation_date { get; set; }
        public string model_num { get; set; }
    }
}
