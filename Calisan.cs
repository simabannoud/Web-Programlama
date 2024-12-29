using System.ComponentModel.DataAnnotations;

namespace Güzellik_Salonu.Models
{
    public class Calisanlar
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Uzmanlik { get; set; } // Örnek: Saç Kesimi, Boyama
        public string Musaitlik { get; set; } // Örnek: "09:00-18:00"
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}
