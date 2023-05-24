using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 5; 
        
       
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + " "); 
            }
            
            Console.WriteLine();
        }
        
        for (int i = size - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + " "); 
            }
            
            Console.WriteLine();
        }
    }
}
