using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteos_v2017
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmParticipantes f = new frmParticipantes();
            f.MdiParent = this;
            f.Top = 0;
            f.Left = 0;
            f.Show();
        }

        private void nuevoSorteoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmSorteos f = new frmSorteos();
            f.MdiParent = this;
            f.Top = 0;
            f.Left = 0;
            f.Show();
        }

        private void otorgarBoletosToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAsignarBoletos f = new frmAsignarBoletos();
            f.MdiParent = this;
            f.Top = 0;
            f.Left = 0;
            f.Show();
        }

        private void listaDeSorteosToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmListarSorteos f = new frmListarSorteos();
            f.MdiParent = this;
            f.Top = 0;
            f.Left = 0;
            f.Show();
        }

        private void verMisParticipacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaDeSorteosToolStripMenuItem_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException("Función no implementada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException("Programado por Edwin Fredy Morales Morales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
