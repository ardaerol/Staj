using System;
using System.Collections.Generic;
using System.Text;

namespace GameService2
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
