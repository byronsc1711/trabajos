using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class UsuarioAutomovil
    {
        [Key]
        [ForeignKey(name: "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Key]
        [ForeignKey(name: "Automovil")]
        public int AutomovilId { get; set; }
        public Automovil Automovil { get; set; }
    }
}
