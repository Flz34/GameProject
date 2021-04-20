using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Buy(Gamer gamer, Game game, Campaign campaign, Sales sales)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" isimli oyuncu "+game.GamePrice+" Lira tutarındaki "+game.GameName + " oyununu "+ campaign.CapmpaignDiscount+" Lira indirimle satın aldı ");
        }

        public void Return(Gamer gamer, Game game, Campaign campaign, Sales sales)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu " + game.GamePrice + " Lira tutarındaki " + game.GameName + " oyununu " +" iade etti. ");

        }
    }
}
