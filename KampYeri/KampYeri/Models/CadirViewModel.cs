using Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace KampYeri.Models
{
    public class CadirViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public KampBolgesiViewModel? KampBolgesi { get; set; }
        public int KampBolgesiId { get; set; }
        public int RowNum { get; set; }
    }
}
