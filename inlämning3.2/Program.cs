using System;
using System.ComponentModel.Design;
namespace inlämning3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Hej! Vi söker ny personal på vårat företag.");
                Console.WriteLine("Har du gått ut gymnasiet? ( j / n )");
                string gåttut = Console.ReadLine();
                Console.WriteLine("Hur gammal är du?");
                int ålder = int.Parse(Console.ReadLine());
                int x;
                int y;
                if (gåttut == "j")
                {
                    x = 1;
                }
                else
                {
                    x = 0;
                }
                if (ålder < 22)
                {
                    y = 1;
                }
                else
                {
                    y = 0;
                }
                
                if ((x + y )== 2)
                {
                    Console.WriteLine("Vi vill gärna anställa dig.");
                }
                else
                {
                    Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
                }
            }

        }
    }
}