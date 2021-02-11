using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Untilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message) : this(success)  //iki farklı yapıyıda bir arada kullanabilmemize yaradı
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
