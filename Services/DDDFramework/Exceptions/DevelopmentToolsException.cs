using System.Runtime.Serialization;

namespace DDDFramework.Core.Domain.Exceptions
{
    [Serializable]
    public class DevelopmentToolsException : Exception
    {
        public DevelopmentToolsException(string? message = null) : base(message)
        {
        }

        public DevelopmentToolsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DevelopmentToolsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    [Serializable]
    public class DevelopmentToolsException<TExcepion> : DevelopmentToolsException
        where TExcepion : DevelopmentToolsException<TExcepion>, new()
    {
        public DevelopmentToolsException(string? message = null) : base(message)
        {
        }

        public DevelopmentToolsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DevelopmentToolsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static TExcepion Create(params object[] @params) => Activator.CreateInstance(typeof(TExcepion), @params) as TExcepion ?? new TExcepion();
    }
}
