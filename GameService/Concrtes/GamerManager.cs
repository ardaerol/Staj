using GameService.Abstract;
using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Concrtes
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt hatalı.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
