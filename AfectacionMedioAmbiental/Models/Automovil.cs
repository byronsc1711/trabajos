using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class Automovil
    {
        public int AutomovilId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<UsuarioAutomovil> UsuarioAutomoviles { get; set; }

    }


}
     
