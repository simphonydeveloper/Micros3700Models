using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_mi_def
    {
        public int store_seq { get; set; }
        public int mi_seq { get; set; }
        public int? version_seq { get; set; }
    }
}
