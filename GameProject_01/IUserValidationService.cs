using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
        bool Delete(Gamer gamer);
    }
}
