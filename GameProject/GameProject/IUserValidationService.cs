using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
     interface IUserValidationService // Kullanıcıyı doğrulamak için
    {
        bool Validate(Gamer gamer);        
    }
}
