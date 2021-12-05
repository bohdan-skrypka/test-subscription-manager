using Ardalis.SmartEnum;
using SubscriptionsManager.Tier;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionsManager
{
    public abstract class Subscriptions : SmartEnum<Subscriptions>
    {
        public static readonly Subscriptions Free = new FreeTier();
        public static readonly Subscriptions Premium = new PremiumTier();
        public static readonly Subscriptions Vip = new VipTier();

        public abstract double Discount { get; }

        public Subscriptions(string name, int value) : base(name, value)
        {

        }
    }
}
