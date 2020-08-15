using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    interface IOperacion
    {
        void calcular(double a, double b);
        void mostrar();
    }
}
