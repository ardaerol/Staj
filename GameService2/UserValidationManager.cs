using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName=="ARDA" && gamer.LastName=="EROL" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
