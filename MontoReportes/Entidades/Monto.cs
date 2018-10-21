using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontoReportes.Entidades
{
  public  class Monto
    {
        [Key]
        public int MontoId { get; set; }
        public string Descripsion { get; set; }
        public string Tipo { get; set; }
        public float monto { get; set; }
        public DateTime FechaDeVencimineto { get; set; }

        public virtual List<CuentaDetalle> Cuentas { get; set; }


        public Monto()
        {
            MontoId = 0;
            Descripsion = string.Empty;
            Tipo = string.Empty;
            monto = 0;
            FechaDeVencimineto = DateTime.Now;
            Cuentas = new List<CuentaDetalle>();
        }
    }
}
