using System;
namespace GameProject
{
    class Program
    {
        static void Main(String[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id = 1 , BirthYear = 1985, FirstName = "Yiğit", LastName = "Bekiroğlu", IdentyNumber = 12345 }) ;
            
            
        }
    }
}
