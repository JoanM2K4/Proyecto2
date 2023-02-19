using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo
{
    class CMenu
    {
        private double opcion, numero1,numero2,resultado;
        private double[] datos= new double[3];
        public void FMostrarMenu() 
        {
            CCalculadora calculador1 = new CCalculadora();
            do
            {

                Console.WriteLine("Ingrese la operacion de realizar:");
                Console.WriteLine("[1]Sumar\t[2]restar\n[3]multiplicar\t[4]dividir\n[5]salir\n");
                opcion = Convert.ToDouble(Console.ReadLine());
                if (opcion>=1&&opcion<=4) 
                {
                    Console.WriteLine("Ingrese primer digito:");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo digito:");
                    numero2 = Convert.ToDouble(Console.ReadLine());

                    datos[0] = opcion;
                    datos[1] = numero1;
                    
                    datos[2] = numero2;
                    calculador1.set_decision2(datos);
                    resultado = calculador1.get_decision2();
                    Console.WriteLine($"El resultado es : {resultado}");
                }
            } while (opcion<5);
            
        }
    }
}
