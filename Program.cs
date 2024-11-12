using System.Transactions;

namespace Challenge2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
            Console.WriteLine("Enter an single digit integer (0 - 9)");
            Console.Write("Number: ");
            string numChoice = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a width amount");
            Console.Write("Width: ");
            int triWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            
            CreateTriangleWhileFor(numChoice, triWidth);
            CreateTriangleNestedFor(numChoice, triWidth);
            

        }

        //Create a triangle of n width out of chosen number with a nested forloop in a while loop
        static void CreateTriangleWhileFor(string num, int width)
        {
            int count = width;
            while (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                count--;
            }
        }

        //Create a triangle of n width out of chosen number with a nested forloop
        static void CreateTriangleNestedFor(string num, int width)
        {
            int count = width;
            for (int i = 0; i <= width; i++)
            {
                
                for(int j = 0; j < count; j++)
                {
                    Console.Write(num);
                }

                count--;
                Console.WriteLine();
            }
        }
    }
}
