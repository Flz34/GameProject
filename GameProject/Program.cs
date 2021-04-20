using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni doğrulama sistemini entegre etmek için 
            //new GamerManager(new NewStateUserValidationManager()) yazmak yeterlidir.

            Gamer gamer1 = new Gamer(); Gamer gamer2 = new Gamer(); Gamer gamer3 = new Gamer();
            gamer1.Id = 1;  gamer1.FirstName = "Filiz"; gamer1.LastName = "Kahrıman";gamer1.IdentityNumber = 12345; gamer1.BirthYear = 1998;
            gamer2.Id = 2;  gamer2.FirstName = "Gamze"; gamer2.LastName = "Kavunç";  gamer2.IdentityNumber = 222222;  gamer2.BirthYear = 1997;
            gamer3.Id = 3;  gamer3.FirstName = "Dilan"; gamer3.LastName = "Kaya";    gamer3.IdentityNumber = 333331;  gamer3.BirthYear = 1996;


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game(); Game game2 = new Game();
            game1.Id = 1; game1.GameName = "Brawl Stars";    game1.GamePrice = 500;
            game2.Id = 2; game2.GameName = "Clash of Clans"; game2.GamePrice = 200;

            GameManager gameManager = new GameManager();
            gameManager.Add(game2);

            Campaign campaign1 = new Campaign(); Campaign campaign2 = new Campaign();
            campaign1.Id = 1; campaign1.CampaignName = "Muhteşem Kasım Günleri"; campaign1.CapmpaignDiscount = 60;
            campaign2.Id = 1; campaign2.CampaignName = "Muhteşem Mayıs Günleri"; campaign2.CapmpaignDiscount = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(game1,campaign1);

            Sales sales1 = new Sales();
            sales1.Id = 1;
            sales1.SaleDate = DateTime.Now;

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(gamer1, game1, campaign1, sales1);
            
        }
    }
}
