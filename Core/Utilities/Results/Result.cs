using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this = Result (Class'ı çalıştır)
        //this(success) = İki parametreli constructer'ı çalıştır aynı zamanda tek parametreli constructer'ı da çalıştır
        public Result(bool success, string message):this(success)  
        {
            Message = message;
        }
        //Overloading
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; } //getter Readonly'dir. Readonly'ler constructer'da set edilebilir
    }
}
