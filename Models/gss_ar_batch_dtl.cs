using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_ar_batch_dtl
    {
        public int ar_batch_dtl_seq { get; set; }
        public DateTime? creation_date { get; set; }
        public string posted { get; set; }
        public DateTime? posted_date { get; set; }
        public string name { get; set; }
    }
}
