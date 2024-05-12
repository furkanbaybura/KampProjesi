using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public  class CadirDto : BaseDto
    {
        public string Ad { get; set; }

        public KampBolgesiDto? KampBolgesi { get; set; }
        public int KampBolgesiId { get; set; }
    }
}
