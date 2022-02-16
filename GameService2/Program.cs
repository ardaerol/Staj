using System;

namespace GameService2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Gamer gamer = new Gamer { Id = 1, BirthYear = 2000, FirstName = "ARDA", LastName = "EROL", IdentityNumber = 12345 };

 GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            Games games = new Games { GameName="LOL", UnitePrice = 20 };
            Campaing campaing = new Campaing { CampaingName = "%50 indirim" };

            OrderManager orderManager = new OrderManager(new UserValidationManager());
            orderManager.Sales(gamer,games,campaing);


        }
    }
}
