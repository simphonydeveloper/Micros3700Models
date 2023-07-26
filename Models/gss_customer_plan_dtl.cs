using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_customer_plan_dtl
    {
        public int customer_plan_dtl_seq { get; set; }
        public int customer_seq { get; set; }
        public int bonus_plan_seq { get; set; }
    }
}
