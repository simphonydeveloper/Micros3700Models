using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_grp_member_dtl
    {
        public int store_grp_seq { get; set; }
        public int child_grp_seq { get; set; }
    }
}
