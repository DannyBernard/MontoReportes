using MontoReportes.BLL;
using MontoReportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontoReportes.UI
{
    public partial class RTipoDeCuentas : Form
    {
        RepositoryBase<TipoDeCuentas> repositoryBase;
        public RTipoDeCuentas()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        private TipoDeCuentas LlenaClase()
        {
            TipoDeCuentas cuentas = new TipoDeCuentas();
            cuentas.TipoID = Convert.ToInt32(IDnumericUpDown.Value);
            cuentas.Descripcion = DescripciontextBox.Text;

            return cuentas;
        }
        private void LlenaCampo(TipoDeCuentas cuentas)
        {
            IDnumericUpDown.Value = cuentas.TipoID;
            DescripciontextBox.Text = cuentas.Descripcion;
        }
    }
}
