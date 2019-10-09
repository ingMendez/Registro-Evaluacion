using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> _Estudiante { get; set; }
        public DbSet<Categoria> _categorias { get; set; }
        public DbSet<Evaluacion> _Evaluacion { get; set; }
        public DbSet<EvaluacionDetalle> _EvaluacionDetalles { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
