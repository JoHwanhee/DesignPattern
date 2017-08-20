using System;

namespace StrategyPattern
{
    class Sword : IAttacker
    {
        public void Attack()
        {
            Console.WriteLine("Sword attack.");
        }
    }
}