#nullable enable
#pragma warning disable CS8618

namespace FinancialAssetsWallet.Core.Models
{
    public abstract class Entity
    {
        public virtual string Id { get; set; }

        public virtual bool HasNotId() => string.IsNullOrWhiteSpace(Id);

        public override bool Equals(object? obj)
        {
            var comparedItem = obj as Entity;

            if (ReferenceEquals(this, comparedItem)) return true;

            if (ReferenceEquals(null, comparedItem)) return false;

            return Id.Equals(comparedItem.Id);
        }

        protected bool Equals(Entity other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}