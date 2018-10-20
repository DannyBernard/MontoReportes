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
    public partial class RCuentasReportes : Form
    {
        private RepositoryBase<Monto> repositoryBase;
        public RCuentasReportes()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DepcripciontextBox.Text = string.Empty;
            MontonumericUpDown.Value = 0;
        }

        private Monto LlenaClase()
        {
            Monto monto = new Monto();
            monto.MontoId = Convert.ToInt32(IDnumericUpDown.Value);
            monto.Descripsion = DepcripciontextBox.Text;
            monto.monto = Convert.ToSingle(MontonumericUpDown.Value);
            return monto;
        }

        private void LlenaCampo(Monto monto)
        {
            IDnumericUpDown.Value = monto.MontoId;
            DepcripciontextBox.Text = monto.Descripsion;
            MontonumericUpDown.Value = Convert.ToDecimal(monto.monto);
        }

        private bool ExiteEnDb()
        {
            repositoryBase = new RepositoryBase<Monto>() ;
            Monto monto = repositoryBase.Buscar((int)IDnumericUpDown.Value);

            return (monto != null);
        }

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DepcripciontextBox.Text))
            {
                errorProvider1.SetError(DepcripciontextBox, "Campo no debe ir vacio");
                paso = false;
            }
            if(MontonumericUpDown.Value == 0)
            {
                errorProvider1.SetError(MontonumericUpDown, "monto debe ser mayor a cero");
                paso = false;
            }
            return paso;
        }
        private void NuevaCuentasbutton_Click(object sender, EventArgs e)
        {
            RTipoDeCuentas rTipoDeCuentas = new RTipoDeCuentas();

            rTipoDeCuentas.Show();
            
        }
    }
}
