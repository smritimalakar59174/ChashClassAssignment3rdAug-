using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent3aug
{
    class AssignmentString
    {
        static void Main()
        {
            string str1, str2;
            Console.Write("\nEnter the First string :\n");
            str1 = Console.ReadLine();
            Console.Write("\nEnter the second string :\n");
            str2 = Console.ReadLine();
      
            Console.WriteLine("...........");
            char ch;
            Console.WriteLine("Enter your choice ");
            ch = Convert.ToChar(Console.ReadLine());
           switch (ch)
            {
                case '1':
                    string strRes1 = String.Concat(str1, str2);
                    Console.WriteLine(strRes1);
                    break;
                case '2':
                   break;
                case '3':

                    Console.WriteLine("Substring of string 1 " + str1.Substring(2));
                    Console.WriteLine("Substring of string 2 " + str2.Substring(4));
                    break;
                case '4':
                    Console.WriteLine(str1 = str1.Replace('a', 'b'));
                    Console.WriteLine(str2 = str2.Replace('s', 'd'));
                    break;
                case '5':

                    Console.WriteLine(str1 = str1.ToUpper());
                    Console.WriteLine(str2 = str2.ToUpper());
                    break;
                case '6':

                    Console.WriteLine(str1 = str1.ToUpper());
                    Console.WriteLine(str1 = str2.ToUpper());
                    break;
                case '7':
                    char[] arr = { ' ', '*' };
                    Console.WriteLine("String = " + str1);
                    Console.WriteLine("String (after trim) = " + str1.Trim(arr));
                    break;
                case '8':
                    char[] separator = { ':', ' ' };
                    string[] word1 = str1.Split(separator);
                    string[] word2 = str2.Split(separator);
                    foreach (string wordcolon in word1)
                    {
                        Console.WriteLine(wordcolon);
                    }
                    foreach (string wordspace in word2)
                    {
                        Console.WriteLine(wordspace);
                    }

                    break;
                case '9':
                    Console.WriteLine("Make a choice again Enter 9 to exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }
    }
}
