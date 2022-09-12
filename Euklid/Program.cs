using System;

namespace Euklid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdR(152, 3384));
            Console.WriteLine(GcdT(33384, 152));
        }
        static int GcdR(int m, int n)
        {
            if (m % n == 0)
            {
                return n;
            }
            else
            {
                return GcdR(n, m % n);
            }
        }
        static int GcdT(int m, int n)
        {
            int tmp;
            while (m%n > 0)
            {
                tmp = n;
                n = m % n;
                m = tmp;
            }
            return n;
        }
    }
}
