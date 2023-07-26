using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hr_school_store_dtl
    {
        public int store_id { get; set; }
        public int school_district_seq { get; set; }
    }
}
