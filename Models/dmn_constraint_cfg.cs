using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dmn_constraint_cfg
    {
        public int dmn_seq { get; set; }
        public decimal dmn_min { get; set; }
        public decimal dmn_max { get; set; }
        public string dmn_msk { get; set; }
    }
}
