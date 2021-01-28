using System;

namespace GameProject_01
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            { Id = 1,
              BirthYear = 1997,
              FirstName = "Mert",
              LastName = "Dikan",
              IdentityNumber = 12345689 });


            gamerManager.Delete(new Gamer
            {
                FirstName = "Mert",
                BirthYear = 1997
            });


            Console.WriteLine("----------------------------------------");

            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Campaing { CampaingName = "Yarı yarıya kampanyası" });
            orderManager.Delete(new Campaing());
            orderManager.Update(new Campaing());


            Console.ReadLine();

        }
    }
}
