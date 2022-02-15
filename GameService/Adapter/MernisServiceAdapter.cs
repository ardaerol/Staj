using GameService.Abstract;
using GameService.Entity;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Adapter
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
