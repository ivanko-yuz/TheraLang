using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Exceptions
{
    public class NoPermissionsException : ApiException
    {
        public NoPermissionsException(string message, params object[] args) : base(message, args)
        {
        }
    }
}
