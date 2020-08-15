using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class ImpactoAmbiental
    {
        public IContaminacion Contaminacion { get; set; }
        public string Afectar()
        {

            var resultadoDesechos = Contaminacion.Desechar("desechos solidos");
            var resultadoExtraccion = Contaminacion.Extraer("gases Naturales");
            var resultadoTratar = Contaminacion.Tratar("aguas residuales");

            return $"{resultadoDesechos}{resultadoExtraccion}{resultadoTratar} ";
        }
    }
}
