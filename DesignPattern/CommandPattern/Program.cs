using System;

namespace CommandPattern
{
    class Program
    {
        static void Main()
        {
            User user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            user.Undo(4);
            user.Redo(3);

            Console.ReadKey();
        }
    }
}
