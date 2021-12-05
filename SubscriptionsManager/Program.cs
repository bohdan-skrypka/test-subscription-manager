using System;

namespace SubscriptionsManager
{
    class Program
    {
        static void Main()
        {
            var free = Subscriptions.Free;
            var premium = Subscriptions.Premium;
            var vip = Subscriptions.Vip;

            var freeByNameSubscription = Subscriptions.FromName("Free");
            var premiumByNameSubscription = Subscriptions.FromName("Premium");
            var vipByNameSubscription = Subscriptions.FromName("Vip");

            var freeByValueSubscription = Subscriptions.FromValue(1);
            var premiumByValueSubscription = Subscriptions.FromValue(2);
            var vipByValueSubscription = Subscriptions.FromValue(3);

            Console.WriteLine(freeByNameSubscription.ToString() + " = " + freeByValueSubscription.Value + " = " + freeByValueSubscription.Discount + "%");
            Console.WriteLine(premiumByNameSubscription.ToString() + " = " + premiumByValueSubscription.Value + " = " + premiumByValueSubscription.Discount + "%");
            Console.WriteLine(vipByNameSubscription.ToString() + " = " + vipByValueSubscription.Value + " = " + vipByValueSubscription.Discount + "%");

            Console.WriteLine(freeByNameSubscription > premiumByNameSubscription);
            Console.WriteLine(freeByNameSubscription < premiumByNameSubscription);
            Console.WriteLine(vipByNameSubscription < premiumByNameSubscription);
            Console.WriteLine(vipByNameSubscription == vipByValueSubscription);
            Console.WriteLine(vipByNameSubscription >= vipByValueSubscription);
        }
    }
}
