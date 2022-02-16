using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Yeni kampanya eklendi");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
