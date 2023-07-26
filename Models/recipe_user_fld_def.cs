using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class recipe_user_fld_def
    {
        public int recipe_seq { get; set; }
        public string alpha_1 { get; set; }
        public string alpha_2 { get; set; }
        public string alpha_3 { get; set; }
        public string alpha_4 { get; set; }
        public string alpha_5 { get; set; }
        public decimal? numeric_1 { get; set; }
        public decimal? numeric_2 { get; set; }
        public decimal? numeric_3 { get; set; }
        public decimal? numeric_4 { get; set; }
        public int? integer_1 { get; set; }
        public int? integer_2 { get; set; }
        public int? integer_3 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
