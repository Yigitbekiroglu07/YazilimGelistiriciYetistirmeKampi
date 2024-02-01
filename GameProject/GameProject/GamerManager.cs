using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    
    class GamerManager : IGamerService
    {
        IUserValidationService   _userValidation;

        public GamerManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu .");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi .");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
