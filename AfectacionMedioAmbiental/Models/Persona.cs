using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AfectacionMedioAmbiental.Models
{
    public class Persona
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        [Required(ErrorMessage =@"Ingrese el apellido")]
        [DisplayName("El Apellido")]
        public string Apellido { get; set; }
        public Celular Celular { get; set; }
        public byte [] FotografiaPerfil { get; set; }

    }
}
