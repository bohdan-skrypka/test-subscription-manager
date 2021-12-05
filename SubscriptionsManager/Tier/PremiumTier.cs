using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionsManager.Tier
{
    public class PremiumTier : Subscriptions
    {
        public override double Discount => 0.25;
        public PremiumTier() : base("Premium", 2)
        {

        }
    }
}
