using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_concept_def
    {
        public int concept_seq { get; set; }
        public string name { get; set; }
        public string db_name { get; set; }
        public string db_server { get; set; }
        public string server_name { get; set; }
        public string connect_string { get; set; }
        public string protocol_string { get; set; }
        public string service_name { get; set; }
        public string server_directory { get; set; }
        public string license_count { get; set; }
        public short is_master_db { get; set; }
        public short db_available { get; set; }
    }
}
