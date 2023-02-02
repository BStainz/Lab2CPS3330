using System;
namespace Lab2Lib
{
    public class Class1
    {
        public static int min(int a, int b)
        {
            return Math.Min(a, b);
        }
        public static int min(int a, int b, int c)
        {
            int min = Math.Min(Math.Min(a, b), c);
            return min;
        }
    }
}