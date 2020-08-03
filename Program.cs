using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent3aug
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new String[5];
            String[] s = { "Zebra", "Ant", "Owl", "Lion" };
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            foreach(string n in s)
                Console.WriteLine(n);
            int j = 0;
            while (j < s.Length)
            {
                Console.WriteLine(s[j]);
                j++;
            }
            int k = 0;

            do
            {
                Console.WriteLine(" {0}",s[k]);
                k++;

            } while (k < s.Length);

            Array.Sort(s);
            foreach (string a in s)
            {
                Console.WriteLine(a);
            }
            Array Animal = new string[5]; 
            String [] ani={ "Zebra", "Kiwi", "Amazona parrot", "Tiger" };
            Array.Sort(ani);
            foreach (string b in ani)
            {
                Console.WriteLine(b);
            }

            Array Places = new string[5]; 
            String[] pla={ "Africa ", "New Zeland", "Jamaica", "India" };
            Array.Sort(pla);
            foreach (string c in pla)
            {
                Console.WriteLine(c);
            }

            Console.Read();
            

        }
    }
}
