using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_ttl_collection_dtl
    {
        public int store_seq { get; set; }
        public int hist_ttl_seq { get; set; }
        public string ttl_managed { get; set; }
    }
}
