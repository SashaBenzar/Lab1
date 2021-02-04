using System;

namespace Lab1_1
{
    public class Program
    {
        static public float SerArh(int a, int b)
        {
            float sa = (a + b)/2;
            Console.WriteLine("середнє арифметичне:" + sa.ToString());
            return sa;
        }
        static public float SerGeo(int a, int b)
        {
            float sg = (float)Math.Sqrt(a * b);
            Console.WriteLine("середнє геометричне:" + sg.ToString());
            return sg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Console.WriteLine("Введiть друге число");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            SerArh(a, b);
            SerGeo(a, b);
        }
    }
}
