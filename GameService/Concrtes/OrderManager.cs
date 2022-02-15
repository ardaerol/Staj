using GameService.Abstract;
using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Concrtes
{
    public class OrderManager : IOrderService
    {
        public void Sales(Games games, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + campaing.CampaingName + " kampanyası" + games.GameName + " isimli oyunu " + games.Unitprice + " Tl");
        }
    }
}
