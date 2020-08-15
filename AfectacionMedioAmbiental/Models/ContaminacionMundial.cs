using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class ContaminacionMundial : IContaminacion
    {
        public string Desechar(string desechosSolidos)
        {
            return $"Se afecta al ambiente por la cantidad de {desechosSolidos} a nivel mundial";
        }

        public string Extraer(string gasesNaturales)
        {
            return $"Al extraer los {gasesNaturales} afecta en el calentamiento global";
        }

        public string Tratar(string aguasResiduales)
        {
            return $"Los contaminantes de {aguasResiduales} son sustancias toxicas para el ambiente a nivel mundial";
        }
    }
}
