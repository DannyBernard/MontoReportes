using MontoReportes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontoReportes.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Monto> Montos { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
