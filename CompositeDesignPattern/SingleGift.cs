﻿/******************************************************************************
 * Filename    = SingleGift.cs
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
    public class SingleGift : GiftBase
    {
        public SingleGift(string name,decimal price) : base(name, price) { }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with the price {price}");

            return price;
        }
    }
}
