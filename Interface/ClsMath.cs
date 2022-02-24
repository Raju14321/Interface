using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class ClsMath :Program, IMath1, IMath_2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
      static void Main()
      {
            ClsMath c = new ClsMath();
            c.Add(100, 45);
            c.Sub(100, 120);
            c.Mul(30, 3);
            c.Div(38, 5);
            c.Mud(55, 78);
            Console.ReadLine();
      }
      
    }
}
