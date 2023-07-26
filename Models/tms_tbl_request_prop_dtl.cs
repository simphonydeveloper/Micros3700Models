using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_tbl_request_prop_dtl
    {
        public int tbl_request_prop_dtl_seq { get; set; }
        public int tbl_request_dtl_seq { get; set; }
        public int tbl_prop_value_seq { get; set; }
    }
}
