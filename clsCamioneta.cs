using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMensualAutomovil
{
    internal class clsCamioneta : clsTarifa
    {
        public double horas {  get; set; }

        public override double CalularTarifa()
        {
            return horas * 45;
        }
    }
}
