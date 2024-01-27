using ExampleCore2.Models.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExampleCore2.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]//Başka bir sınıfa validasyon olayını yüklemiş olduk
    public class Product
    {
        //Aşağıdaki [] içinde annotation ile istediğiniz doğrulama kontrolü yapılıyor.Yukarıdaki sınıf da mutlaka eklenmesi gerekiyor.
        //[Required( ErrorMessage ="Lütfen Değeri Gir")]
        public int id { get; set; }
        public string name { get; set; }
        //[StringLength(10,ErrorMessage ="10'dan fazla girme gardaş")]
        public string description { get; set; }
        //[EmailAddress(ErrorMessage ="E-mail Gir")]
        public string category { get; set; }
    }
}
