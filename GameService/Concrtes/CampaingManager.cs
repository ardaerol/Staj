using GameService.Abstract;
using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Concrtes
{
   public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Yeni Kampanya eklendi.");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
