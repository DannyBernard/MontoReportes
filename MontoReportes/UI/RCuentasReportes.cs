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
        public List<CuentaDetalle>Detalle { get; set; }
        public RCuentasReportes()
        {
            InitializeComponent();
            this.Detalle = new List<CuentaDetalle>();
            LlenaComboBox();
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
            monto.FechaDeVencimineto = FechadateTimePicker.Value;
            monto.Cuentas = this.Detalle;
            return monto;
        }

        private void LlenaCampo(Monto monto)
        {
            IDnumericUpDown.Value = monto.MontoId;
            DepcripciontextBox.Text = monto.Descripsion;
            MontonumericUpDown.Value = Convert.ToDecimal(monto.monto);
            FechadateTimePicker.Value = monto.FechaDeVencimineto;
            this.Detalle = monto.Cuentas;
            CargarGrid();
        }

        private bool ExiteEnDb()
        {
            repositoryBase = new RepositoryBase<Monto>() ;
            Monto monto = repositoryBase.Buscar((int)IDnumericUpDown.Value);

            return (monto != null);
        }
        public void LlenaComboBox()
        {
            RepositoryBase<TipoDeCuentas> repository = new RepositoryBase<TipoDeCuentas>();
            TipocomboBox.DataSource = repository.GetList(x => true);
            TipocomboBox.ValueMember = "Descripcion";
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
            if (FechadateTimePicker.Value < DateTime.Now)
            {
                errorProvider1.SetError(FechadateTimePicker, "Fecha Invalida");
                paso = false;
            }
            return paso;
        }
        private void NuevaCuentasbutton_Click(object sender, EventArgs e)
        {
            RTipoDeCuentas rTipoDeCuentas = new RTipoDeCuentas();

            rTipoDeCuentas.Show();
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositoryBase = new RepositoryBase<Monto>();
            bool paso = false;
            Monto monto;
            if (!Validar())
                return;
            monto = LlenaClase();
            if (IDnumericUpDown.Value == 0)
                paso = repositoryBase.Guardar(monto);
            else
            {
                if (!ExiteEnDb())
                {
                    MessageBox.Show("No se puede Modificar no exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositoryBase.Modificar(monto);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Fallo no se guardo", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repositoryBase = new RepositoryBase<Monto>();
            errorProvider1.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (repositoryBase.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorProvider1.SetError(IDnumericUpDown, "no se puedo eliminar");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            repositoryBase = new RepositoryBase<Monto>();
            Monto monto = new Monto();
            int.TryParse(IDnumericUpDown.Text, out id);
            monto = repositoryBase.Buscar(id);
            if (monto != null)
            {
                errorProvider1.Clear();
                LlenaCampo(monto);
                MessageBox.Show("Encotrado");
            }
            else
            {
                MessageBox.Show("No se Encotro");
            }

        }
        private void CargarGrid()
        {
            CuentadataGridView.DataSource = null;
            CuentadataGridView.DataSource = this.Detalle;
        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            RCuentasReportes rCuentas = new RCuentasReportes();
            if (CuentadataGridView.DataSource != null)
                this.Detalle = (List<CuentaDetalle>)CuentadataGridView.DataSource;
            this.Detalle.Add(
                new CuentaDetalle
                (
                    ID: 0,
                    CuentaID: (int)IDnumericUpDown.Value,
                    TipoCuenta: TipocomboBox.Text

                 )
                    );
            CargarGrid();
            DepcripciontextBox.Focus();
            DepcripciontextBox.Clear();
        }
    }
}
