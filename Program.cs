using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            
            do 
            {
                Console.WriteLine("[1]suman\n[2]resta\n[3]division\n[4]multiplicacion\n[5]powering\n[6]salir");
                opcion= int.Parse(Console.ReadLine());
            } 
            while (opcion != 6);    
            switch (opcion)
            {
                case 1:
                    
                case 2:
                    ;
                case 3:
                    ;
                case 4:
                    ;
                case 5:
                    ;
                case 6:
                    ;
                default:
                    Console.WriteLine("No introdujo ninguna de las  opciones posibles");

            }
        }
    }
}
