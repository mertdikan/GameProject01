using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Delete(Gamer gamer)
        {
            return true;
        }

        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
