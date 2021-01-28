using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    interface ICampaingService
    {
        void Add(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
