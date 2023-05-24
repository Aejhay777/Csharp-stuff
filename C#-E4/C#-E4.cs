using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 6; 
   
        for (int i = 1; i <= size; i++)
        {
            int num = i;
            for (int j = 1; j < size; j++)
            {
                Console.Write(num + " ");
                num *= i + 1;
            }
            Console.WriteLine();
        }

   }
}