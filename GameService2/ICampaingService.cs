using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    interface ICampaingService
    {
        void Add(Campaing campaing);

        void Delete(Campaing campaing);

        void Update(Campaing campaing);
    }
}
