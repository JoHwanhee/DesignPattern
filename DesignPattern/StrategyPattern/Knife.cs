using System;

namespace StrategyPattern
{
    class Knife : IAttacker
    {
        public void Attack()
        {
            Console.WriteLine("Knife attack");
        }
    }
}