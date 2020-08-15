using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    interface IFacturas
    {
        decimal CalcularIgv(decimal monto);
        int redondeaMonto(decimal monto);
    }
}
