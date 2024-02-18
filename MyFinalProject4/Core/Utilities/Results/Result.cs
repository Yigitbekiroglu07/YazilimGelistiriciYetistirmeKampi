using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResults
    {
        

        public Result(bool success, string message):this(success) // this = Result, 17. satırın da aynı anda çalışması için this gönderilir.
        {
            Message = message;  // Aşağıdaki Message'ı message olarak set  
        }
        public Result(bool success) // Overloading
        {
            Success = success;  
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
