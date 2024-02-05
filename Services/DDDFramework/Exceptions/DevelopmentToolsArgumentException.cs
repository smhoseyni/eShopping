using System.Runtime.Serialization;

namespace DDDFramework.Core.Domain.Exceptions
{
    [Serializable]
    public class DevelopmentToolsArgumentException<TException> : DevelopmentToolsException<TException>
        where TException : DevelopmentToolsArgumentException<TException>, new()
    {
        public DevelopmentToolsArgumentException(string? message = null) : base(message)
        {
        }

        protected DevelopmentToolsArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
