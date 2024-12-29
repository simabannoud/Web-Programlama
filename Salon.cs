using System.Drawing;

namespace Güzellik_Salonu.Models
{
    public class Salon
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string CalismaSaatleri { get; set; } // Örnek: "09:00-18:00"
        public List<Calisanlar> Calisanlar { get; set; }
    }
}
