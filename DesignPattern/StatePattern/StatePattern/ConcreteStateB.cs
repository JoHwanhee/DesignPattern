using System;

namespace StatePattern
{
    class ConcreteStateB : IState
    {
        public void Handle()
        {
            Console.WriteLine("B");
        }
    }
}