using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
          
            bool sant=false;
            while (!sant) {
                Console.Write("Skriv inn en temperatur: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int temperatur)) {
                    switch (Math.Sign(temperatur))
                    {
                        case 1:
                            Console.WriteLine("Temperaturen er pluss.");
                            break;
                        case -1:
                            Console.WriteLine("Temperaturen er minus.");
                            break;
                        case 0:
                            Console.WriteLine("Temperaturen er null.");
                            break;
                    }
                    sant= true;
                }
                else
                {
                    Console.WriteLine("Du må skrive tall");
                    
                }
            }

            Console.ReadLine();




            //oppgave 4
            //Leg det hele i Git. Public repo. Send linken i oppgave i teams.


        }
    }
}
