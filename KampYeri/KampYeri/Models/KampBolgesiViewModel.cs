using Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace KampYeri.Models
{
    public class KampBolgesiViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public IEnumerable<CadirViewModel>? Cadirlar { get; set; }
        public int RowNum { get; set; }
    }
}
