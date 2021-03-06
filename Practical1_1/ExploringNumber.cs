using System;

namespace  NumbersApp
{
    class Numbers{
        public static void IntDemo(){
            int a = 18;
            int b = 16;
            int c = 4;
            Console.WriteLine("\nOperations on Integers:");
            Console.WriteLine("\na+b : "+ (a+b) + "\n");
            Console.WriteLine("a-b : "+ (a-b)+"\n");
            Console.WriteLine("a*b : "+ (a*b)+"\n");
            Console.WriteLine("a/b : "+(a/b)+"\n");
            Console.WriteLine("Explore Order of Operations: ");
            Console.WriteLine("\na + b * c : " + (a + b * c));
            Console.WriteLine("\n(a + b) * c : "+((a + b) * c));
            Console.WriteLine("\n(a + b) - 6 * c + (12 * 4) / 3 + 12 :"+((a + b) - 6 * c + (12 * 4) / 3 + 12));
            Console.WriteLine("\n(a + b) / c :"+((a + b) / c)+"\n");
            Console.WriteLine("Explore integer precision and limits: \n");
            Console.WriteLine($"quotient: {(a + b) / c}\n");
            Console.WriteLine($"remainder: {(a + b) % c}\n");
            Console.WriteLine($"The range of integers is {int.MaxValue} to {int.MinValue}\n");
            //Console.WriteLine($"An example of overflow: {int.MaxValue + 3}\n");
        }

        //working with Double
        public static void DoubleDemo(){
            double a= 5;
            double b = 65.67;
            Console.WriteLine("Working with double : \n");
            Console.WriteLine(("(a+b)/3.14 : "+(a+b)/3.14)+"\n");
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}\n");
            Console.WriteLine("1.0 / 3.0 : "+ (1.0 / 3.0));
        }

        public static void DecimalDemo(){
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"\nThe range of the decimal type is {min} to {max}");
            Console.WriteLine("\nDifference of precision between decimal and double: ");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine("\nDouble : "+(a / b));
   
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine("\nDecimal : "+(c / d));
        }

        public static void findArea(){
            double radius = 4.32;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"area for radius {radius} : {area}");
        }
    }
}