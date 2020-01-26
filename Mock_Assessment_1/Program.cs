using System;

namespace Mock_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;

            if (IsTheSame(x, y))
            {
                Console.WriteLine("the same");
            }
            else
            {
                Console.WriteLine("different");
            }

            FindBuildingType(1);
            FindBuildingType(11);
            FindBuildingType(10);
            FindBuildingType(55);
        }

        public static bool IsTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static void FindBuildingType(int num)
        {
            if(num < 3)
            {
                Console.WriteLine("This is a house!");
            }
            else if (num >= 4 & num <= 10)
            {
                Console.WriteLine("This is an office building!");
            }
            else if (num >= 11 && num <= 49)
            {
                Console.WriteLine("This is a skyscraper!");
            }
            else
            {
                Console.WriteLine("This is a SUPER skyscaper");
            }
        }
    }
}
