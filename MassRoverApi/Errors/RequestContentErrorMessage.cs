using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassRoverApi.Errors
{
    public class RequestContentErrorMessage : ErrorMessage
    {
        public RequestContentErrorMessage()
        {
            Code = ErrorCode.RequestContentMismatch;
            Type = $"https://massrover.com/doc/errors/#{ErrorCode.RequestContentMismatch.ToString()}";

        }
    }
}
