using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message) // base demek Result classından alıyor demek
        { 

     
        } // base >> Result   

        public SuccessResult() : base(true) // Mesaj verme, base'in tek parametreli olanını çalıştır
        {

        }
    }


   
}
