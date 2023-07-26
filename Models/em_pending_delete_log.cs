using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_pending_delete_log
    {
        public string table_name { get; set; }
        public string value_list { get; set; }
        public string column_list { get; set; }
        public int? sqlcode_error { get; set; }
        public DateTime? last_delete_attempt { get; set; }
    }
}
