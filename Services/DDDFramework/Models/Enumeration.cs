using System.Reflection;

namespace DDDFramework.Core.Domain.Models
{
    public abstract record Enumeration<T> : BaseValueObject, IComparable where T : Enumeration<T>
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll()
        {
            var fields = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).ToList();

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override int GetHashCode() => Id.GetHashCode();

        public static int AbsoluteDifference(Enumeration<T> firstValue, Enumeration<T> secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Id - secondValue.Id);
            return absoluteDifference;
        }

        public static T FromValue(int value)
        {
            var matchingItem = Parse(value, "value", item => item.Id == value);
            return matchingItem;
        }

        public static T FromDisplayName(string displayName)
        {
            var matchingItem = Parse(displayName, "display name", item => item.Name == displayName);
            return matchingItem;
        }

        private static T Parse<K>(K value, string description, Func<T, bool> predicate)
        {
            var matchingItem = GetAll().FirstOrDefault(predicate);

            return matchingItem ?? throw new InvalidOperationException($"'{value}' is not a valid {description} in {typeof(T)}");
        }

        public int CompareTo(object? other) => Id.CompareTo(((Enumeration<T>?)other)?.Id);    }
}
