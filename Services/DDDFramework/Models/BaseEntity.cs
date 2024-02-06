namespace DDDFramework.Core.Domain.Models
{
    public class BaseEntity<TEntity, TId> : IModel
        where TEntity : BaseEntity<TEntity, TId>
       // where TId : struct
    {
        private int? _requestedHashCode;

        public TId Id { get; protected set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not BaseEntity<TEntity, TId>)
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            var item = (BaseEntity<TEntity, TId>)obj;

            return item.Id.Equals(Id);
        }
        public override int GetHashCode()
        {
            if (!_requestedHashCode.HasValue)
                _requestedHashCode = Id.GetHashCode() ^ 31;

            return _requestedHashCode.Value;
        }
        public static bool operator ==(BaseEntity<TEntity, TId>? left, BaseEntity<TEntity, TId>? right)
        {
            return Equals(left, null) ?
                    Equals(right, null) :
                    left.Equals(right);
        }
        public static bool operator !=(BaseEntity<TEntity, TId>? left, BaseEntity<TEntity, TId>? right)
        {
            return !(left == right);
        }
    }
}
