using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontoReportes.Entidades
{
  public  class TipoDeCuentas
    {
        [Key]
        public int TipoID { get; set; }
        public string Descripcion { get; set; }

        public TipoDeCuentas()
        {
            TipoID = 0;
            Descripcion = string.Empty;
        }
    }
}
