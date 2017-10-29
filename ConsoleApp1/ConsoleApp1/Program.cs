using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Hello(int n)
        {
            int i;
            string text;
            for (i=0; i<n; i++)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\CFiles\1.txt");
                while ((text = file.ReadLine()) != null)
                {
               
                    Console.WriteLine(text);
                    
                }
                file.Close();
            }
           
        }
        static void Main()
        {
            int n;
            Console.WriteLine("How much 'Hello World's do you want to see?: ");
            n = int.Parse( Console.ReadLine());
            Hello(n);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
