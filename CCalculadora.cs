using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo
{
     class CCalculadora
    {
        private double respuesta;
        public double FCalcular(double[] decision2)
        {
            switch (decision2[0]) 
            {
                case 1:
                    respuesta= decision2[1] + decision2[2];
                    break;
                case 2:
                    respuesta = decision2[1] - decision2[2];
                    break;
                case 3:
                    respuesta = decision2[1] * decision2[2]; 
                    break;
                case 4:
                    respuesta = decision2[1] / decision2[2]; 
                    break;

            }


            return respuesta;
        }
    }
}
