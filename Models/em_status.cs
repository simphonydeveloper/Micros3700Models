using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_status
    {
        public int status_seq { get; set; }
        public int store_seq { get; set; }
        public string store_type { get; set; }
        public string db_type { get; set; }
        public int concept_seq { get; set; }
    }
}
