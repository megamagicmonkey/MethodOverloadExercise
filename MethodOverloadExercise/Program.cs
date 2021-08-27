using System;

namespace MethodOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDollar = true;
            bool notDollar = false;

            int lint;
            double trouble;
            string thing;

            lint = Add(5, 7);
            Console.WriteLine(lint);
            trouble = Add(5.5, 1.3);
            Console.WriteLine(trouble);
            thing = Add(5, 7, isDollar);
            Console.WriteLine(thing);
            thing = Add(5, 7, notDollar);
            Console.WriteLine(thing);
            thing = Add(1, 0, isDollar);
            Console.WriteLine(thing);
            
        }
        public static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public static double Add(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        public static string Add(int x, int y, bool dollars)
        {
            int sum = x + y;
            char? plural = 's';
            if (sum == 1){plural = null;}

            if (dollars)
            {
                return $"{sum} dollar{plural}";
            }
            else
            {
                return $"{sum}";
            }
        }
    }
}

