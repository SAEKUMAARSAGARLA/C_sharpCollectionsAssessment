/*4)	Write Custom Generic class MyStack based on assignment of previous session, with
Push() and Pop() methods to store any kind of .NET Type.using System;*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_sharpGenericAssessment
{
    internal class Stacks
    {
        static void Main()
        {
            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push("Employee");
            stack1.Push(27);
            stack1.Push("saekumaar sagarla");
            foreach (Object obj in stack1)
            {
                Console.WriteLine("data in stack" + ":" + obj);
            }
            stack1.Pop();
            foreach (Object obj in stack1)
            {
                Console.WriteLine("after pop operation" + ":" + obj);
            }

            Console.ReadLine();
        }
    }
}
