using System.ComponentModel.DataAnnotations;

namespace TagHelperUygulama.Models
{
    public class Kullanici
    {
        [EmailAddress]
        public string EPosta { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DogumTarihi { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostaKodu { get; set; }
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}
