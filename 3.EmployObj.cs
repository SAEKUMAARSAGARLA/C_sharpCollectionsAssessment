/*3)	Write a console based program to create a linked list of Employee objects using the generic class List<>.Perform following operations on the list:
a.	Add a new employee
b.	Display the list of employees.
c.	Total number of employees in the list
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharpGenericAssessment
{
    internal class GenaricList
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("sae kumaar");
            list.Add("Rama");
            list.Add("Krishna");
            list.Add("vinayak");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list[i]);
            }
            Console.WriteLine("total number of employess" + ':' + list.Count);
            Console.ReadLine();
        }
    }
}
