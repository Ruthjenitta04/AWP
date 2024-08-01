using System;

    class Funtion
    {
        public void demo()
        {
            Console.WriteLine("Enter four integer values:");


            Console.Write("Value 1: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Value 2: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Value 3: ");
            int value3 = int.Parse(Console.ReadLine());

            Console.Write("Value 4: ");
            int value4 = int.Parse(Console.ReadLine());


            int product = value1 * value2 * value3 * value4;


            Console.WriteLine("The product of " + value1 + " " +value2 + " "+value3 + " " +value4 + " is: " + product);

        }
    }
    class Prac1a
    {
        static void Main(string[] args)
        {
            Funtion obj1 = new Funtion();
            obj1.demo();
        }

    }
