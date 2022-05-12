using System;

namespace FinancialAssetsWallet.Core.Models
{
    public static class IdentityGenerator
    {
        public static string NewGuidId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}