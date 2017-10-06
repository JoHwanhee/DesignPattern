using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{

    class Program
    {
        static void Main(string[] args)
        {
            IState[] sts = { new ConcreteStateA(), new ConcreteStateB() };
            Context c = new Context(sts[0]);

            int toggle = 0;
            c.Request(sts[toggle = 1 - toggle]);
            c.Request(sts[toggle = 1 - toggle]);
            c.Request(sts[toggle = 1 - toggle]);
            c.Request(sts[toggle = 1 - toggle]);
        }
    }
}