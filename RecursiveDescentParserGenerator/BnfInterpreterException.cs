﻿using System;
using System.Runtime.Serialization;

namespace RecursiveDescentParserGenerator
{
    /// <summary>
    /// Represents errors that occur during the interpretation of BNF (Backus-Naur Form) grammar.
    /// </summary>
    internal class BnfInterpreterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BnfInterpreterException"/> class.
        /// </summary>
        public BnfInterpreterException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BnfInterpreterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BnfInterpreterException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BnfInterpreterException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public BnfInterpreterException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BnfInterpreterException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected BnfInterpreterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
