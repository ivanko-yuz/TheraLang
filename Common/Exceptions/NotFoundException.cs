using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Exceptions
{
    public class NotFoundException : ApiException
    {
        public NotFoundException() : base()
        {
        }

        public NotFoundException(string itemName) : base($"{itemName} not found!")
        {
        }
    }
}
