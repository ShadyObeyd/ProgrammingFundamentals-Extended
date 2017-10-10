using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
    class Stateless
    {
        static void Main()
        {
            string state = Console.ReadLine();
            while (state != "collapse")
            {
                string friction = Console.ReadLine();

                while (friction.Length > 0)
                {
                    state = state.Replace(friction, "").Trim();

                    friction = friction.Remove(0, 1);

                    if (friction.Length > 0)
                    {
                        friction = friction.Remove(friction.Length - 1, 1);
                    }

                }

                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(state);
                }
                state = Console.ReadLine();
            }
        }
    }
}
