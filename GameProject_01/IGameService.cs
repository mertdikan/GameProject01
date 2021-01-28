using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    interface IGameService
    {
        void Add(Gamer gamer);
        void Update (Gamer gamer);
        void Delete (Gamer gamer);

    }

}
