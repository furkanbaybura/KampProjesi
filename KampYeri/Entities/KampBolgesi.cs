using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class KampBolgesi : BaseEntity
    {
        public string Ad {  get; set; }
        public IEnumerable<Cadir>? Cadirlar {  get; set; }


    }
}
