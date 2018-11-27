using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassRoverApi.Errors
{
    public class EntityNotFoundErrorMessage : ErrorMessage
    {
        public EntityNotFoundErrorMessage()
        {
            Code = ErrorCode.RequestContentMismatch;
            Type = $"https://massrover.com/doc/errors/#{ErrorCode.EntityNotFound.ToString()}";
        }
    }
}
