using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
