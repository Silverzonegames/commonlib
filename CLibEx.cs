using Silverzone.CommonLib.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverzone.CommonLib.Ex
{
    public static class CLibEx
    {
        /// <summary>
        /// Call returns no value
        /// </summary>
        [Serializable]
        public class NullReturnException : Exception
        {
            public NullReturnException() { }
            public NullReturnException(string message) : base(message) { }
            public NullReturnException(string message, Exception inner) : base(message, inner) { }
            protected NullReturnException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        /// <summary>
        /// Authentication is handled over an insecure connection
        /// </summary>
        [Serializable]
        public class InsecureAuthException : Exception
        {
            public InsecureAuthException() { }
            public InsecureAuthException(string message) : base(message) { }
            public InsecureAuthException(string message, Exception inner) : base(message, inner) { }
            protected InsecureAuthException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        /// <summary>
        /// Authentication does not have all required parameters
        /// </summary>
        [Serializable]
        public class MissingOrNullAuthArgumentException : Exception
        {
            public MissingOrNullAuthArgumentException() { }
            public MissingOrNullAuthArgumentException(string message) : base(message) { }
            public MissingOrNullAuthArgumentException(string message, Exception inner) : base(message, inner) { }
            protected MissingOrNullAuthArgumentException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        /// <summary>
        /// Authentication Endpoint/Provider is not a valid Endpoint/Provider for anonymous authentication
        /// </summary>
        [Serializable]
        public class InvalidAnonAuthEndpointException : Exception
        {
            public InvalidAnonAuthEndpointException() { }
            public InvalidAnonAuthEndpointException(string message) : base(message) { }
            public InvalidAnonAuthEndpointException(string message, Exception inner) : base(message, inner) { }
            protected InvalidAnonAuthEndpointException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        /// <summary>
        /// A Common Library Initializer object was missing
        /// </summary>
        [Serializable]
        public class MissingClibInitobject : Exception
        {
            public MissingClibInitobject() { }
            public MissingClibInitobject(string message) : base(message) { }
            public MissingClibInitobject(string message, Exception inner) : base(message, inner) { }
            protected MissingClibInitobject(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class MissingOrInvalidPath : Exception
        {
            public MissingOrInvalidPath() { }
            public MissingOrInvalidPath(string message) : base(message) { }
            public MissingOrInvalidPath(string message, Exception inner) : base(message, inner) { }
            protected MissingOrInvalidPath(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }


        [Serializable]
        public class MissingOrInvalidURI : Exception
        {
            public MissingOrInvalidURI() { }
            public MissingOrInvalidURI(string message) : base(message) { }
            public MissingOrInvalidURI(string message, Exception inner) : base(message, inner) { }
            protected MissingOrInvalidURI(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
