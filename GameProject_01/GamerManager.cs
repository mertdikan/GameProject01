using System;
using System.Collections.Generic;
using System.Text;
//MicroService
namespace GameProject_01
{
    
    class GamerManager : IGameService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Gerçekleştirildi ");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız");
            }
        }

          public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Silindi");
            }
            else
            {
                Console.WriteLine("Kayıt Silmek için doğru isim giriniz");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncelledi");
        }
    }
}
