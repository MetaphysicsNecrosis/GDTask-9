using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_9
{
    internal class Program
    {
        public static String ROTik(String target)
        {
            String newS = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (Char.IsLetter(target[i]))
                {
                    if ((target[i] > 64 && target[i] < 78) ||
                        (target[i] > 96 && target[i] < 110))
                    {
                        newS += ((char)(target[i] + 13));
                    }
                    else 
                    {
                        newS += ((char)(target[i] - 13));
                    }
                }
                else newS += (target[i]);
            }
            return newS;
        }

        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            s = ROTik(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
