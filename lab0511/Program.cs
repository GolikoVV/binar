using System;
namespace БиномНьютона
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Степень бинома - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(бином(n));
            Console.ReadKey();
        }
        
        static string бином(int n)
        {
            string s = "1 + ";
            for (int k = 1; k <= n; k++)
                s = s + bk(n, k).ToString() + "x^" + k.ToString() + " + ";
            string s1 = s.Remove(s.Length - 3);
            s = "(1+x)^" + n.ToString() + " = " + s1;
            return s;
        }
        
        static int bk(int n, int k)
        {
            long t = 1;
            for (int i = n - k + 1; i <= n; i++)
                t = t * i;
            for (int i = 2; i <= k; i++)
                t = t / i;
            return (int)t;
        }
    }
}