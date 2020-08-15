using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class Facturacion : IFacturas
    {

        public decimal CalcularIgv(decimal monto)
        {
            decimal IGV = 0.18M;

            return monto = IGV;
        }

        public int redondeaMonto(decimal monto)
        {
            return (int)Math.Round(monto);
        }
    }
}