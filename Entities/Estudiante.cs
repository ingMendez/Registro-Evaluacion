using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{   [Serializable]
    public class Estudiante
    {                 [Key]
        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public Estudiante()
        {
            IdEstudiante = 0;
            NombreEstudiante = string.Empty;
            Matricula = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
