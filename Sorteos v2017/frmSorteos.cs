using BusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteos_v2017
{
    public partial class frmSorteos : Form
    {
        public frmSorteos()
        {
            InitializeComponent();
        }

        private void frmSorteos_Load( object sender, EventArgs e )
        {

        }

        private void btnCrearSorteo_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty( this.txtNombreSorteo.Text ))
            {
                MessageBox.Show( "Escriba el nombre del sorteo", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Information );
                this.txtNombreSorteo.Focus();
                return;
            }

            if (Int32.Parse( nudTotalBoletos.Value.ToString() ) == 0)
            {
                MessageBox.Show( "Ingrese el numero de boletos que tendrá el sorteo", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Information );
                nudTotalBoletos.Focus();
                return;
            }

            if (Int32.Parse( nudTotalBoletos.Value.ToString() ) > 10000)
            {
                MessageBox.Show( "El numero maximo de boletos para un sorteo es 10000", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Information );
                nudTotalBoletos.Focus();
                return;
            }

            if (MessageBox.Show( "¿Esta seguro de crear el sorteo?", "Crear sorteo", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No)
            {
                return;
            }

            try
            {
                GenericServices<Sorteo>.Insertar( new Sorteo { NombreSorteo = txtNombreSorteo.Text, TotalBoletos = Int32.Parse( nudTotalBoletos.Value.ToString() ), FechaSorteo = dtpFechaSorteo.Value } );
                GenericServices<Sorteo>.Guardar();

                if (MessageBox.Show( "El sorteo ha sido creado correctamente.\n\n¿Desea crear otro sorteo?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
                {
                    txtNombreSorteo.Text = string.Empty;
                    nudTotalBoletos.Value = 0;
                    dtpFechaSorteo.Value = DateTime.Now;
                }
                else
                    this.Close();
                
            }
            catch (ArgumentException ae)
            {

                MessageBox.Show( this, ae.Message, "Mensaje del sistema [" + ae.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void btnCerrar_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
