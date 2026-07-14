using System;
using System.Runtime.Serialization;
using WorldRank.Domain.Enums;

namespace WorldRank.Domain.Exceptions
{
    public class WalletBlockedException : WalletException
    {
        public Guid WalletId { get; }
        public Currency Currency { get; }

        public WalletBlockedException(Guid walletId) : base($"Wallet {walletId} is blocked.")
        {
            WalletId = walletId;
        }

        public WalletBlockedException(Currency currency) : base($"Wallet with currency {currency} is blocked.")
        {
            Currency = currency;
        }

        protected WalletBlockedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            WalletId = info.GetValue(nameof(WalletId), typeof(Guid)) is Guid id ? id : Guid.Empty;
            Currency = info.GetValue(nameof(Currency), typeof(Currency)) is Currency c ? c : default;
        }

        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(WalletId), WalletId);
            info.AddValue(nameof(Currency), Currency);
        }
    }
}