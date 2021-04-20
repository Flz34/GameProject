using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        //doğrulama yapacağım parametremde gamer
        bool Validation(Gamer gamer); 
    }
}
