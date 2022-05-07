namespace FinnacialAssetsWallet.Domain.Model
{
    public abstract class Entity
    {
        public virtual string Id { get; set; }

        public virtual void GenerateNewGuidIdentity()
        {
            if (HasNotId())
            {
                Id = IdentityGenerator.NewGuidId();
            }
        }

        public virtual bool HasNotId() => string.IsNullOrWhiteSpace(Id);
    }
}