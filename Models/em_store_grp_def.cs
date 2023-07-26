using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_store_grp_def
    {
        public int store_grp_seq { get; set; }
        public int enterprise_seq { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public int? group_contains { get; set; }
        public int? items_exist_in_only_one_group { get; set; }
        public int? group_use { get; set; }
        public int? visible { get; set; }
    }
}
