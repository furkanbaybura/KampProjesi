using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cadir : BaseEntity
    {
        public string Ad {  get; set; }
        public KampBolgesi? KampBolgesi { get; set; }
        public int KampBolgesiId { get; set;}
    }
}
