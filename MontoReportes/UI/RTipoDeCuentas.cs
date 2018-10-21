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

        private bool ExiteEnLaDb()
        {
            repositoryBase = new RepositoryBase<TipoDeCuentas>();
            TipoDeCuentas tipoDeCuentas = repositoryBase.Buscar((int)IDnumericUpDown.Value);
            return (tipoDeCuentas != null);
        }

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo Vacio");

                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            repositoryBase = new RepositoryBase<TipoDeCuentas>();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if(repositoryBase.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado Con exito");
            }
            else
            {
                errorProvider1.SetError(IDnumericUpDown, "Id no puede set 0");
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            repositoryBase = new RepositoryBase<TipoDeCuentas>();
            int id;
            TipoDeCuentas tipo = new TipoDeCuentas();
            int.TryParse(IDnumericUpDown.Text, out id);
           tipo = repositoryBase.Buscar(id);
            if(tipo != null)
            {
               // errorProvider1.Clear();
                LlenaCampo(tipo);
                MessageBox.Show("Busqueda Exitosa");
            }
            else
            {
                MessageBox.Show("Busqueda Fallida");
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            repositoryBase = new RepositoryBase<TipoDeCuentas>();
            bool paso = false;
            TipoDeCuentas tipoDeCuentas;
            if (!Validar())
                return;
            tipoDeCuentas = LlenaClase();
            if (IDnumericUpDown.Value == 0)

                paso = repositoryBase.Guardar(tipoDeCuentas);
            else
            {
                if (!ExiteEnLaDb())
                {
                    MessageBox.Show("No Exite No es editaable");
                    return;
                }

                paso = repositoryBase.Modificar(tipoDeCuentas);
            }
            Limpiar();
            if (paso)
                MessageBox.Show("Guardo con Exito");
            else
                MessageBox.Show("Error no se guardo");
        }
    }
}
