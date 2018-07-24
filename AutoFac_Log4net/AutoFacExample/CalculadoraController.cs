using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacExample
{
    public class CalculadoraController : ICalculadora
    {
        private readonly log4net.ILog _logger;

        public CalculadoraController(ILog logger) {
            _logger = logger;
        }

        public int Div(int num1, int num2){

            int cociente = 0;

            try
            {
                cociente =  num1 / num2;
            }
            catch (DivideByZeroException ex) {
                _logger.Error(ex);
              //  THROW NEW EXCEPTIOn("Intento de dividir por zero");
            }

            return cociente;
        }
    }

    
}
