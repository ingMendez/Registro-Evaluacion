using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Categoria
    {   [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public DateTime Fecha { get; set; }

        public Categoria()
        {
            IdCategoria = 0;
            NombreCategoria = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
