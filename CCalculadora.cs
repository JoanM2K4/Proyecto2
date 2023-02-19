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
        private double[] decision2= new double[3];
        public void set_decision2(double[] pDecision2) 
        {
            decision2=pDecision2;
            FCalcular();
        }
        private void FCalcular()
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


            
        }
        public double get_decision2() 
        {
            return respuesta;
        }
    }
}
