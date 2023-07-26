using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xplr_node_err_dtl
    {
        public int node_seq { get; set; }
        public int store_id { get; set; }
        public DateTime err_time { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
