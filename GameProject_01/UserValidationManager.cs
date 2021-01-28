using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_01
{
    class UserValidationManager : IUserValidationService
    {
        public bool Delete(Gamer gamer)
        {
            if (gamer.FirstName == "Mert" && gamer.BirthYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1997 && gamer.FirstName=="Mert" && gamer.LastName =="Dikan"&& gamer.IdentityNumber==12345689 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
