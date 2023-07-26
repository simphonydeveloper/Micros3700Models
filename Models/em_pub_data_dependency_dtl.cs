using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_pub_data_dependency_dtl
    {
        public int parent_data_seq { get; set; }
        public int dependent_data_seq { get; set; }
        public int? ob_delete { get; set; }
    }
}
