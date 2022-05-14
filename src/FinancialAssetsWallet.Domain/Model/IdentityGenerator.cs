using System;

namespace FinancialAssetsWallet.Domain.Model
{
    public static class IdentityGenerator
    {
        public static string NewGuidId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}