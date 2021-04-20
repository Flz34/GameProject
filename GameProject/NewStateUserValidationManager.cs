using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Yeni bir kimlik doğrulama servisi kullanacağımızı varsayalım 
    class NewStateUserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
