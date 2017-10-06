using System;

namespace StatePattern
{
    class ConcreteStateA : IState
    {
        public void Handle()
        {
            Console.WriteLine("A");
        }
    }
}