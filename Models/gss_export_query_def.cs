using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_export_query_def
    {
        public int export_query_seq { get; set; }
        public string name { get; set; }
        public string sql_statement { get; set; }
    }
}
