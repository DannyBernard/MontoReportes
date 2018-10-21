using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontoReportes.Entidades
{
   public class CuentaDetalle
    {
        [Key]
        public int ID { get; set; }
        public int CuentaID { get; set; }
        public string TipoCuentas { get; set; }

        public CuentaDetalle(int ID,int CuentaID,string TipoCuenta)
        {
            this.ID = ID;
            this.CuentaID = CuentaID;
            this.TipoCuentas = TipoCuenta;
        }
        
    }

    
}
