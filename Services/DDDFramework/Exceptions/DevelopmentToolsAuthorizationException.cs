using System.Runtime.Serialization;

namespace DDDFramework.Core.Domain.Exceptions
{
    [Serializable]
    public class DevelopmentToolsAuthorizationException<TException> : DevelopmentToolsException<TException>
        where TException : DevelopmentToolsArgumentException<TException>, new()
    {
        public DevelopmentToolsAuthorizationException(string? message = null) : base(message)
        {
        }

        protected DevelopmentToolsAuthorizationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
