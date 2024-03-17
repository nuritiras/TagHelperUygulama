using System.ComponentModel.DataAnnotations;

namespace TagHelperUygulama.Models
{
    public class Kullanici
    {
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }
        [EmailAddress]
        [Display(Name = "Eposta Adresi")]
        public string EPosta { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon Numarası")]
        public string Telefon { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name = "Posta Kodu")]
        public string PostaKodu { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
