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
    public partial class frmParticipantes : Form
    {
        bool EsNuevo;
        bool EsEditar;
        Participante participante;
        int ParticipanteEditarId;

        public frmParticipantes()
        {
            InitializeComponent();
            btnOtorgarBoletos.Visible = false;
        }

        private Form Form1;

        public frmParticipantes(Form form)
        {
            InitializeComponent();
            btnOtorgarBoletos.Visible = true;
            this.Form1 = form;
            this.Form1.Hide();
        }

        private void frmParticipantes_Load( object sender, EventArgs e )
        {
            FuncionesAuxiliares.HabilitarTextbox( scContenedor.Panel2, false);

            var lista = NParticipante.MostrarTodos();
            dgvParticipantes.DataSource = lista;

            dgvParticipantes.Columns["ParticipanteId"].Visible = false;
            dgvParticipantes.Columns["Boletos"].Visible = false;
            dgvParticipantes.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";
            dgvParticipantes.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";
            dgvParticipantes.Columns["FechaModificado"].HeaderText = "Fecha de Registro";
        }        

        private void txtParticipanteABuscar_KeyUp( object sender, KeyEventArgs e )
        {
            dgvParticipantes.DataSource = NParticipante.BuscarParticipantePorNombreApellidos(txtParticipanteABuscar.Text);         
        }

        private void btnNuevo_Click( object sender, EventArgs e )
        {
            EsNuevo = true;
            EsEditar = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;            
            FuncionesAuxiliares.HabilitarTextbox( scContenedor.Panel2, true );
            txtNombre.Focus();
            FuncionesAuxiliares.LimpiarTextbox( scContenedor.Panel2 );
        }

        private void btnEditar_Click( object sender, EventArgs e )
        {
            EsNuevo = false;
            EsEditar = true;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;            
            btnGuardar.Enabled = true;
            FuncionesAuxiliares.HabilitarTextbox( scContenedor.Panel2, true );
            txtNombre.Focus();
        }

        private void btnGuardar_Click( object sender, EventArgs e )
        {
            participante = new Participante();            

            try
            {
                if (string.IsNullOrEmpty( txtNombre.Text ) || string.IsNullOrEmpty( txtApellidoPaterno.Text ))
                {
                    throw new NoNullAllowedException("Debe ingresar por lo menos el nombre y apellido paterno");
                }

                if (EsNuevo)
                {
                    participante.Nombre = txtNombre.Text;
                    participante.ApellidoPaterno = txtApellidoPaterno.Text;
                    participante.ApellidoMaterno = txtApellidoMaterno.Text;
                    participante.Telefono = txtTelefono.Text;
                    participante.Celular = txtCelular.Text;
                    participante.CorreoElectronico = txtCorreoElectronico.Text;
                    participante.Direccion = txtDireccion.Text;

                    NParticipante.AgregarParticipante( participante );       
                }

                if (EsEditar)
                {
                    if (ParticipanteEditarId == 0)
                    {
                        tcParticipantes.SelectedIndex = 0;
                        throw new NoNullAllowedException("Debe seleccionar un participante a editar");
                    }

                    participante = GenericServices<Participante>.BuscarPorId( ParticipanteEditarId );

                    participante.Nombre = txtNombre.Text;
                    participante.ApellidoPaterno = txtApellidoPaterno.Text;
                    participante.ApellidoMaterno = txtApellidoMaterno.Text;
                    participante.Telefono = txtTelefono.Text;
                    participante.Celular = txtCelular.Text;
                    participante.CorreoElectronico = txtCorreoElectronico.Text;
                    participante.Direccion = txtDireccion.Text;

                    GenericServices<Participante>.Actualizar( participante );
                    GenericServices<Participante>.Guardar();
                    ParticipanteEditarId = 0;
                    btnEditar.Enabled = false;
                }

                FuncionesAuxiliares.LimpiarTextbox( scContenedor.Panel2 );
                EsNuevo = false;
                EsEditar = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                frmParticipantes_Load( sender, e );
                tcParticipantes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show( this, ex.Message, "Mensaje del sistema [" +  ex.GetType().ToString()+"]", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void btnCerrar_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void dgvParticipantes_DoubleClick( object sender, EventArgs e )
        {
            txtNombre.Text = dgvParticipantes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellidoPaterno.Text = dgvParticipantes.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
            txtApellidoMaterno.Text = dgvParticipantes.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
            txtTelefono.Text = dgvParticipantes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCelular.Text = dgvParticipantes.CurrentRow.Cells["Celular"].Value.ToString();
            txtCorreoElectronico.Text = dgvParticipantes.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
            txtDireccion.Text = dgvParticipantes.CurrentRow.Cells["Direccion"].Value.ToString();

            EsEditar = true;
            EsNuevo = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;

            ParticipanteEditarId = Int32.Parse(dgvParticipantes.CurrentRow.Cells["ParticipanteId"].Value.ToString());

            tcParticipantes.SelectedIndex = 1;
        }

        private void btnOtorgarBoletos_Click( object sender, EventArgs e )
        {
            try
            {
                frmAsignarBoletos.ParticipanteId = Int32.Parse(dgvParticipantes.CurrentRow.Cells["ParticipanteId"].Value.ToString());

                Form1.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Debe seleccionar un participante", "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCorreoElectronico_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCorreoElectronico.Text))
                {
                    var correo = new System.ComponentModel.DataAnnotations.EmailAddressAttribute();

                    if (!correo.IsValid(txtCorreoElectronico.Text))
                    {
                        txtCorreoElectronico.Focus();
                        throw new FormatException("Formato de correo electrónico no válido");
                    }
                }                
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}