using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    //MicroService
    class GamerManager : IGamerService
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
                Console.WriteLine("Kayıt başarılı..");
            }
            else
            {
                Console.WriteLine("Bilgiler doğrulanamadı. Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi..");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi..");
        }
    }
}
