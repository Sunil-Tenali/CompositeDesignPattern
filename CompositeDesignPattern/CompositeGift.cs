/******************************************************************************
 * Filename    = CompositeGift.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Navigates a linked list and notifies a listener when a node is visited.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> _gifts;

        public CompositeGift(string name, decimal price) : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }
        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }
        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;

            Console.WriteLine($"{name} contains the following products with prices:");

            foreach (GiftBase gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
