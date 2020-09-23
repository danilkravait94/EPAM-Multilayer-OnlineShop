using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleEShop.Exceptions
{
    public class AccessException : Exception
    {
        public AccessException()
        {
        }

        public AccessException(string message) : base(message)
        {
        }

        public AccessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
