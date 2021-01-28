using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    class OrderManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Yeni kampanya eklenmiştir " + campaing.CampaingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya silinmiştir");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanyalarımıza güncelleme gelmiştir");
        }
    }
}
