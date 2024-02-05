using System.Runtime.Serialization;

namespace DDDFramework.Core.Domain.Exceptions
{
    [Serializable]
    public class DevelopmentToolsAuthenticationException<TException> : DevelopmentToolsException<TException>
        where TException : DevelopmentToolsArgumentException<TException>, new()
    {
        public DevelopmentToolsAuthenticationException(string? message = null) : base(message)
        {
        }

        protected DevelopmentToolsAuthenticationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
