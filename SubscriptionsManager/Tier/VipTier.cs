using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionsManager.Tier
{
    public class VipTier : Subscriptions
    {
        public override double Discount => 0.5;
        public VipTier() : base("Vip", 3)
        {

        }
    }
}
