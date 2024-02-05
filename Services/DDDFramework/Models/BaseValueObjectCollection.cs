namespace DDDFramework.Core.Domain.Models
{
    public abstract record BaseValueObjectCollection<TValueObject> : IReadOnlyCollection<TValueObject>, IModel
        where TValueObject : BaseValueObject
    {

        private readonly List<TValueObject> _value;

        public BaseValueObjectCollection(IList<TValueObject> value)
        {
            _value = new(value);
        }

        public int Count => _value.Count;
        public IEnumerator<TValueObject> GetEnumerator() => _value.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => _value.GetEnumerator();
    }
}
