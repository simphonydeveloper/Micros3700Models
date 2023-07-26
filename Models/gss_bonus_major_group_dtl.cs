using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_bonus_major_group_dtl
    {
        public int bonus_major_group_dtl_seq { get; set; }
        public int bonus_seq { get; set; }
        public int? maj_grp_seq { get; set; }
    }
}
