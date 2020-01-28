using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main()
        {
            string s;
            s = Console.ReadLine();
            string[] AliceString = s.Split(' ');
            int[] Alice = new int[3];
            for(int i = 0; i<3; i++)
            {
                Alice[i] = Convert.ToInt32(AliceString[i]);
            }
            s = Console.ReadLine();
            string[] BobString = s.Split(' ');
            int[] Bob = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Bob[i] = Convert.ToInt32(BobString[i]);
            }
            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;
            {
                for(int i = 0; i < 3; i++)
                {
                    if (Alice[i] > Bob[i])
                    {
                        result[0]++;
                    }
                    else if (Bob[i] > Alice[i])
                    {
                        result[1]++;
                    }
                }
                Console.WriteLine("{0} {1}", result[0], result[1]);
            }
            Console.ReadKey();
        }
    }
}