using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class table_purge_list_temp
    {
        public int id { get; set; }
        public string table_name { get; set; }
        public string cutoff_list { get; set; }
        public string group_name { get; set; }
    }
}
