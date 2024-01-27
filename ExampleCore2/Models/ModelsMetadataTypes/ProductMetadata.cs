using System.ComponentModel.DataAnnotations;

namespace ExampleCore2.Models.ModelMetadataTypes
{
    public class ProductMetadata
    {
        [Required(ErrorMessage = "Lütfen Değeri Gir")]
        public int id { get; set; }
        [StringLength(10, ErrorMessage = "10'dan fazla girme gardaş")]
        public string description { get; set; }
        [EmailAddress(ErrorMessage = "E-mail Gir")]
        public string category { get; set; }
    }
}
