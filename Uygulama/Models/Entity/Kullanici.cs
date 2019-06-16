using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Uygulama.App_Class;

namespace Uygulama.Models.Entity
{
    [FluentValidation.Attributes.Validator(typeof(KullaniciValidator))]
    public class Kullanici
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Ad { get; set; }
        [Required]
        [MaxLength(50), MinLength(2)]
        public string Soyad { get; set; }
        [Required]
        [MaxLength(50)]
        public string Il { get; set; }
        [Required]
        [MaxLength(50)]
        public string Ilce { get; set; }
        [Required]
        public int Tutar { get; set; }
        [Required]
        public bool BorcluMu { get; set; }
        [Required]
        [MaxLength(500), MinLength(5)]
        public string Aciklama { get; set; }
    }

    public class Kullanicilar
    {
        public Kullanici kullanicilar { get; set; }
    }
}