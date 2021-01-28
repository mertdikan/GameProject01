using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya Eklenmiştir");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya Silinmiştir");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya Güncellenmiştir");
        }
    }
}
