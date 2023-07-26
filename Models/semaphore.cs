using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class semaphore
    {
        public string type { get; set; }
        [Column("semaphore")]
        public short? semaphore_1 { get; set; }
    }
}
