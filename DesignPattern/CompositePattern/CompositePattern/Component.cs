using System;

namespace CompositePattern
{
    public abstract class Component
    {
        public string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}