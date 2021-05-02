﻿using System;
using System.Runtime.Serialization;

namespace IdoitSharp
{
    public class IdoitBadResponseException : Exception
    {
        // Constructors
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