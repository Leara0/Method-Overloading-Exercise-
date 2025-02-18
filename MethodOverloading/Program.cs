namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(1, 2);
            Console.WriteLine(sum);

            decimal sum1 = Add(1.8m, 2.3m);
            Console.WriteLine(sum1);

            string dollars = Add(1, 2, true);
            Console.WriteLine(dollars);
            
            dollars = Add(0, 1, true);
            Console.WriteLine(dollars);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
            if (c)
            {
                int value = a + b;
                if (value > 1)
                    return $"{value} dollars";
                else
                {
                    return $"{value} dollar";
                }
            }

            return "";
        }
    }
}