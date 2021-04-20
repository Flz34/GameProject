using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        //satış
        void Buy(Gamer gamer, Game game, Campaign campaign, Sales sales);
        //iade
        void Return(Gamer gamer, Game game, Campaign campaign, Sales sales);
    }
}
