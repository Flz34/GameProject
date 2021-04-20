using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        //true-false olarak döndürmek istiyorum bu yüzden void i bool yapmam gerek IUserValidationService den bool türüne çevir. Dolayısıyla burada da imzaya uymak zorunda
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear== 1998 && gamer.FirstName== "Filiz" && gamer.LastName=="Kahrıman" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false; //kullanıcı bilgisi hatalı
            }
        }
    }
}
