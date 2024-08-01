using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random binary code");
            Console.Write("\nHow many numbers you need:");
            int numberLength = Convert.ToInt32(Console.ReadLine()); 

            int[] cucumbers = new int[numberLength];

            Random rand = new Random();

            for (int i = 0; i < cucumbers.Length; i++)
            {
                cucumbers[i] = rand.Next(0,2);

                Console.Write($"{cucumbers[i]}");
            }
        }
    }
                    
}
