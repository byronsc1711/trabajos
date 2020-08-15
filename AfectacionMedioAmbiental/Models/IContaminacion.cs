using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public interface IContaminacion
    {
        string Desechar(string desechosSolidos);
        string Extraer(string gasesNaturales);
        string Tratar(string aguasResiduales);

    }
}
