using System;
using System.Runtime.Serialization;

namespace IdoitSharp
{
    /// <summary>
    /// The exception that is thrown when when an idoit request was not valid.
    /// </summary>
    public class IdoitBadResponseException : Exception
    {
        public IdoitBadResponseException(string message) : base(message)
        {
        }

        // Ensure Exception is Serializable
        protected IdoitBadResponseException(SerializationInfo info,
            StreamingContext text) : base(info, text)
        {
        }
    }
}