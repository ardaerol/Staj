using GameService.Abstract;
using GameService.Adapter;
using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Concrtes
{
    public class GamerCheckManager : IGamerCheckService
    {
        
        
            IGamerCheckService _gamerCheckService;

            public bool CheckGamerIfRealPerson(Gamer gamer)
            {

                _gamerCheckService = new MernisServiceAdapter();
                return _gamerCheckService.CheckGamerIfRealPerson(gamer);
            }
        
    }
}
