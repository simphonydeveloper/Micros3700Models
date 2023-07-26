using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dbsrpc_db_updates_status
    {
        public int seq { get; set; }
        public string skip_updates { get; set; }
        public int? pause_len_mins { get; set; }
        public string request_from { get; set; }
    }
}
