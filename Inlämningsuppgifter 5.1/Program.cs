using System;
namespace Inlämningsuppgifter5_1
{
    class program
    {
        static void Main(string[] args)
        {
            
            
            
            string[] M = new string[3];
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Skriv in en mening");
                M[i] = Console.ReadLine();

            }
            Console.WriteLine("Dessa meningarna skrev du");
            for (int i = 0; i < 3; i++) 
                Console.WriteLine(M[i]);
           






        }
    }
}