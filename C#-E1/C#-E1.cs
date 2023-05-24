class Program
{
    static void Main(string[] args)
    {
        int n = 4;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < (n - i - 1) * 19; j++)
            {
                Console.Write(" "); 
            }

            Console.Write("*"); 
            for (int j = 0; j < i * 38; j++)
            {
                Console.Write(" "); 
            }

            if (i != 0)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }

        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < (n - i - 1) * 19; j++)
            {
                Console.Write(" "); 
            }

            Console.Write("*"); 

            for (int j = 0; j < i * 38; j++)
            {
                Console.Write(" "); 
            }

            if (i != 0)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }
        
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < (n - i - 1) * 19; j++)
            {
                Console.Write(" "); 
            }

            Console.Write("*"); 

            for (int j = 0; j < i * 38; j++)
            {
                Console.Write(" "); 
            }

            if (i != 0)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }        
        
        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < (n - i - 1) * 19; j++)
            {
                Console.Write(" "); 
            }

            Console.Write("*"); 

            for (int j = 0; j < i * 38; j++)
            {
                Console.Write(" "); 
            }

            if (i != 0)
            {
                Console.Write("*"); 
            }

            Console.WriteLine();
        }        
        
    }
}
