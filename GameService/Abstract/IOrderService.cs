using GameService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameService.Abstract
{
    public interface IOrderService
    {
        void Sales(Games games, Gamer gamer, Campaing campaing);
    }
}
