using BusinessLayer;
using DrawsDAL;
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
    public partial class frmListarSorteos : Form
    {
        int SorteoId;
        int ParticipanteId = 0;
        int GanadorId = 0;
        int NumGanador = 0;

        public frmListarSorteos()
        {
            InitializeComponent();
        }

        private void frmListarSorteos_Load( object sender, EventArgs e )
        {
            try
            {
                NSorteo.LlenarCombobox(cbSorteos, "NombreSorteo", "SorteoId");
                NSorteoReferencia.LlenarCombobox(cbSorteoRef, "NombreSorteo", "SorteoReferenciaId");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSorteos_SelectedIndexChanged( object sender, EventArgs e )
        {
            try
            {
                SorteoId = Int32.Parse(cbSorteos.SelectedValue.ToString());

                var sorteo = GenericServices<Sorteo>.BuscarPorId(SorteoId);

                txtBoletosEmitidos.Text = sorteo.TotalBoletos.ToString();
                txtBoletosDisponibles.Text = (sorteo.TotalBoletos - NBoleto.ObtenerNumerosOtorgados(SorteoId).Count()).ToString();

                dgvParticipantes.DataSource = NParticipante.ObtenerParticipantesPorSorteo(SorteoId);
                dgvParticipantes.Columns["ParticipanteId"].Visible = false;
                dgvParticipantes.Columns["Boletos"].Visible = false;
                dgvParticipantes.Columns["Nombre"].HeaderText = "Nombres";
                dgvParticipantes.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";
                dgvParticipantes.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";
                dgvParticipantes.Columns["FechaModificado"].HeaderText = "Fecha de Registro";

                if ((sorteo.TotalBoletos - NBoleto.ObtenerNumerosOtorgados(SorteoId).Count()) == 0)
                {
                    //Verificar si ya se registro al ganador del sorteo seleccionado(Probar aun)
                    panelGanador.Visible = true;
                    FuncionesAuxiliares.LimpiarTextbox(panelGanador);

                    Ganador Ganador = GenericServices<Ganador>.ListarTodos().Where(g => g.SorteoId == SorteoId).SingleOrDefault();


                    if (Ganador != null)
                    {
                        GanadorId = Ganador.ParticipanteId;
                        NumGanador = Ganador.BoletoElectronico;

                        Participante partGanador;

                        using (var db = new SorteosDB())
                        {
                            partGanador = db.Participantes.Find(GanadorId);
                        }
                        //MessageBox.Show(partGanador.ToString());
                        cbSorteoRef.Enabled = false;
                        cbSorteoRef.SelectedItem = Ganador.SorteoReferencia;
                        txtGanador.Text = partGanador.ToString();
                        txtNumGanador.Text = NumGanador.ToString();// NumGanador.ToString();                    
                        txtNumGanador.Enabled = false;
                        txtNumSorteoReferencia.Text = Ganador.NumeroSorteoReferencia.ToString();
                        txtNumSorteoReferencia.Enabled = false;
                        txtEnlaceVerificacion.Text = Ganador.LinkVerificacionSorteo;
                        //txtEnlaceVerificacion.Enabled = false;
                        txtEnlaceVerificacion.ReadOnly = true;
                        btnSaveWinner.Enabled = false;
                    }
                    else
                    {
                        cbSorteoRef.Enabled = true;
                        txtGanador.Text = "";//Ganador;
                        //txtNumGanador.Text = NumGanador.ToString();
                        txtNumSorteoReferencia.Enabled = true;
                        txtNumGanador.Enabled = true;
                        //txtEnlaceVerificacion.Enabled = true;
                        txtEnlaceVerificacion.ReadOnly = false;
                        btnSaveWinner.Enabled = true;
                    }
                }
                else
                {
                    panelGanador.Visible = false;
                    cbSorteoRef.Enabled = true;
                    txtGanador.Text = "";//Ganador;
                    //txtNumGanador.Text = NumGanador.ToString();
                    txtNumSorteoReferencia.Enabled = true;
                    txtNumGanador.Enabled = true;
                    //txtEnlaceVerificacion.Enabled = true;
                    txtEnlaceVerificacion.ReadOnly = false;
                    btnSaveWinner.Enabled = true;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPartXSorteo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParticipanteId = Int32.Parse(dgvParticipantes.CurrentRow.Cells["ParticipanteId"].Value.ToString());

                var Participaciones = NBoleto.ObtenerNumerosOtorgados(SorteoId, ParticipanteId).ToList();
                lvParticipantesBoletos.Items.Clear();

                foreach (var boleto in Participaciones)
                {
                    string[] row1 = { boleto.CodigoValidacion.ToString().ToUpper() };
                    lvParticipantesBoletos.Items.Add(boleto.BoletoElectronico.ToString()).SubItems.AddRange(row1);
                    //progressBar1.Value += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveWinner_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaEntrada();

                var BoletoGanador = GenericServices<Boleto>.BuscarPorId(SorteoId, GanadorId, NumGanador);

                //Existe registro del numero ganador a su respectivo participante y sorteo
                if (BoletoGanador != null)
                {
                    if (MessageBox.Show("¿Está seguro de registrar al ganador del sorteo?", "Información correcta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Ganador Ganador = new Ganador() { SorteoId = SorteoId, ParticipanteId = GanadorId, BoletoElectronico = NumGanador };

                        Ganador.SorteoReferenciaId = Int32.Parse(cbSorteoRef.SelectedValue.ToString());//SorteoReferenciaId;
                        Ganador.NumeroSorteoReferencia = txtNumSorteoReferencia.Text;
                        Ganador.LinkVerificacionSorteo = txtEnlaceVerificacion.Text;

                        //Guardar al gandador en la base de datos
                        GenericServices<Ganador>.Insertar(Ganador);
                        GenericServices<Ganador>.Guardar();
                                                
                        txtEnlaceVerificacion.ReadOnly = true;
                        txtNumSorteoReferencia.Enabled = false;
                        txtNumGanador.Enabled = false;
                        btnSaveWinner.Enabled = false;
                        MessageBox.Show("El ganador ha sido registrado correctamente", "Registro de ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }                    
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaEntrada()
        {
            if (string.IsNullOrEmpty(txtNumSorteoReferencia.Text) || string.IsNullOrEmpty(txtNumGanador.Text) || string.IsNullOrEmpty(txtEnlaceVerificacion.Text) || string.IsNullOrEmpty(cbSorteoRef.GetItemText(cbSorteoRef.SelectedItem)))
            {
                throw new NoNullAllowedException("Información del sorteo de referencia requerida");
            }
        }

        private void txtNumGanador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtGanador.Text = string.Empty;
            }

            if (!string.IsNullOrEmpty(txtNumGanador.Text))
            {
                if (txtBoletosEmitidos.Text.Equals("10"))
                {
                    if (txtNumGanador.Text.Length >= 1)
                    {
                        NumGanador = Convert.ToInt32(txtNumGanador.Text.Substring(txtNumGanador.Text.Length - 1, 1));
                    }
                }

                if (txtBoletosEmitidos.Text.Equals("100"))
                {
                    if (txtNumGanador.Text.Length >= 2)
                    {
                        NumGanador = Convert.ToInt32(txtNumGanador.Text.Substring(txtNumGanador.Text.Length - 2, 2));
                    }
                }

                if (txtBoletosEmitidos.Text.Equals("1000"))
                {
                    if (txtNumGanador.Text.Length >= 3)
                    {
                        NumGanador = Convert.ToInt32(txtNumGanador.Text.Substring(txtNumGanador.Text.Length - 3, 3));
                    }
                }

                if (txtBoletosEmitidos.Text.Equals("10000"))
                {
                    if (txtNumGanador.Text.Length >= 4)
                    {
                        NumGanador = Convert.ToInt32(txtNumGanador.Text.Substring(txtNumGanador.Text.Length - 4, 4));
                    }
                }

                try
                {
                    //Obtengo el id del participante que tenga el # de Boleto ganador del sorteo de referencia                
                    GanadorId = GenericServices<Boleto>.ListarTodos().Where(p => p.SorteoId == SorteoId && p.BoletoElectronico == NumGanador).Select(i => i.ParticipanteId).SingleOrDefault();

                    //Selecciono el participante con el id obtenido anteriormente
                    var ganador = GenericServices<Participante>.BuscarPorId(GanadorId); //Resultado directo                

                    if (ganador != null) //Si se encuentra el participante en los registros
                    {
                        txtGanador.Text = ganador.ToString();
                    }
                    else
                    {
                        txtGanador.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void TextboxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void lnkVerificacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            try
            {
                if (!string.IsNullOrEmpty(txtEnlaceVerificacion.Text))
                {
                    System.Diagnostics.Process.Start(txtEnlaceVerificacion.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumSorteoReferencia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumSorteoReferencia.Text))
            {
                epListarSorteos.SetError(txtNumSorteoReferencia, "Campo requerido");
                epListarSorteos.SetIconAlignment(txtNumSorteoReferencia, ErrorIconAlignment.MiddleRight);
                return;
            }
            else
            {
                epListarSorteos.SetError(txtNumSorteoReferencia, "");
            }
        }

        private void txtNumGanador_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumGanador.Text))
            {
                epListarSorteos.SetError(txtNumGanador, "Campo requerido");
                epListarSorteos.SetIconAlignment(txtNumGanador, ErrorIconAlignment.MiddleRight);
                return;
            }
            else
            {
                epListarSorteos.SetError(txtNumGanador, "");
            }
        }

        private void txtEnlaceVerificacion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnlaceVerificacion.Text))
            {
                epListarSorteos.SetError(txtEnlaceVerificacion, "Campo requerido");
                epListarSorteos.SetIconAlignment(txtEnlaceVerificacion, ErrorIconAlignment.MiddleRight);
                return;
            }
            else
            {
                epListarSorteos.SetError(txtEnlaceVerificacion, "");
            }
        }

        private void btnImprimirListaParticipantes_Click(object sender, EventArgs e)
        {
            if (SorteoId == 0)
            {
                MessageBox.Show("Debe seleccionar un sorteo para generar la lista", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            GeneratePDF.GenerarPDF(SorteoId);
        }

        private void btnGenerarPdfParticipante_Click(object sender, EventArgs e)
        {
            if (ParticipanteId == 0)
            {                
                MessageBox.Show("Debe seleccionar un participante para generar la lista", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (lvParticipantesBoletos.Items.Count > 0)
            {
                GeneratePDF.GenerarPDF(SorteoId, ParticipanteId);
            }
            else
            {
                MessageBox.Show("No hay participaciones asignadas del participante seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscarParticipante_KeyUp(object sender, KeyEventArgs e)
        {
            dgvParticipantes.DataSource = NParticipante.BuscarParticipantePorNombreApellidos(txtBuscarParticipante.Text);
        }        
    }
}
