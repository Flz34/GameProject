using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununa " + campaign.CampaignName + " kampanyası kapsamında " + campaign.CapmpaignDiscount + " tl indirim tanımlandı.");
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununun " + campaign.CapmpaignDiscount + " TL'lik kampanya süresi sona erdi. ");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununun " + campaign.CapmpaignDiscount + " tl olan  indirimi " + campaign.CapmpaignDiscount + " tl olarak güncellendi.");

        }
    }
}
