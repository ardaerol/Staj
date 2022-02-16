using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    class OrderManager : IOrderService
    {
        IUserValidationService _userValidationService;

        public OrderManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Sales(Gamer gamer, Games games, Campaing campaing)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + games.GameName + " " + "isimli oyunu"
             + " " + campaing.CampaingName + " " + "kampanyası ile" + " " + games.UnitePrice + " " + "fiyatına aldın");
            }
            else
            {
                Console.WriteLine("Bilgiler doğrulanamadı satın alma gerçekleştirilemedi");
            }
            
        }
    }
}
