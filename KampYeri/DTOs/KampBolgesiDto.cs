using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class KampBolgesiDto : BaseDto
    {
        public string Ad { get; set; }
        public IEnumerable<CadirDto>? Cadirlar { get; set; }

    }
}
