using System;

namespace FinnacialAssetsWallet.Domain.Model
{
    public static class IdentityGenerator
    {
        public static string NewGuidId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}