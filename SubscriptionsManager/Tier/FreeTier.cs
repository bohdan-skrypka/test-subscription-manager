using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionsManager.Tier
{
    public class FreeTier : Subscriptions
    {
        public override double Discount => 0.0;
        public FreeTier() : base("Free", 1)
        {

        }
    }
}
