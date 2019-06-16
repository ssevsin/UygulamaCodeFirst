using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Uygulama.Models.Entity;

namespace Uygulama.App_Class
{
    public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.Ad).Length(2, 50).WithMessage("Adı 2 ile 50 karakter arasında olmalıdır").NotEmpty().WithMessage("Adı alanı boş geçilemez.");
            RuleFor(x => x.Soyad).Length(2, 50).WithMessage("Soyadı 2 ile 50 karakter arasında olmalıdır").NotEmpty().WithMessage("Soyadı alanı boş geçilemez.");
            RuleFor(x => x.Il).NotEmpty().WithMessage("İl boş geçilemez");
            RuleFor(x => x.Ilce).NotEmpty().WithMessage("İlçe boş geçilemez");
            RuleFor(x => x.Tutar).NotEmpty().WithMessage("Tutar boş geçilemez");
            RuleFor(x => x.Aciklama).Length(5, 500).WithMessage("Açıklama 5 ile 500 karakter arasında olmalıdır").NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}