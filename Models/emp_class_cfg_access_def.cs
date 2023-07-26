using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_class_cfg_access_def
    {
        public int emp_class_seq { get; set; }
        public int cfg_access_seq { get; set; }
        public short? cfg_form { get; set; }
        public string ob_read_access { get; set; }
        public string ob_update_access { get; set; }
        public string ob_insert_access { get; set; }
        public string ob_delete_access { get; set; }
        public int? last_updated_by { get; set; }
    }
}
