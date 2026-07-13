using System;
using System.Runtime.Serialization;

namespace WorldRank.Domain.Exceptions
{
    public abstract class WalletException : Exception, ISerializable
    {
        public WalletException() { }
        public WalletException(string message) : base(message) { }
        public WalletException(string message, Exception inner) : base(message, inner) { }

        protected WalletException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}