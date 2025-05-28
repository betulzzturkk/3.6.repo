using System.ComponentModel.DataAnnotations;

namespace AutismEducationPlatform.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        public string KullaniciAdi { get; set; }

        [Required]
        public string Sifre { get; set; }
    }
} 