using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_infc_def
    {
        public int infc_infc_seq { get; set; }
        public string name { get; set; }
        public string delimiter { get; set; }
        public string infc_desc { get; set; }
        public string ob_user_defined { get; set; }
        public string ob_append { get; set; }
        public string version { get; set; }
        public string output_filename { get; set; }
        public string output_filepath { get; set; }
        public string output_fileext { get; set; }
        public string output_format { get; set; }
    }
}
