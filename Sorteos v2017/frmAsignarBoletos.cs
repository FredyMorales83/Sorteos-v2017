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
    public partial class frmAsignarBoletos : Form
    {
        List<int> Generados = new List<int>();
        List<int> Otorgados = new List<int>();
        public static int ParticipanteId = 0;
        int MAX_BOLETOS = 0;
        int Boleto;
        int SorteoId;

        public frmAsignarBoletos()
        {
            InitializeComponent();
        }

        private void btnElegirParticipante_Click( object sender, EventArgs e )
        {
            this.Hide();
            frmParticipantes p = new frmParticipantes(this);
            p.Show();
        }

        private void rbAsignacionAutomatica_CheckedChanged( object sender, EventArgs e )
        {
            try
            {
                if (ParticipanteId == 0)
                {
                    throw new NoNullAllowedException("Debe elegir un participante");
                }

                lblNumElegido.Visible = false;
                nudNumeroElegido.Visible = false;
                btnElegirManual.Visible = false;
                btnAsigarAleatorios.Visible = true;
                nudNumeroBoletos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAsignacionManual_CheckedChanged( object sender, EventArgs e )
        {
            try
            {
                if (ParticipanteId == 0)
                {
                    throw new NoNullAllowedException("Debe elegir un participante");
                }

                btnAsigarAleatorios.Visible = false;
                lblNumElegido.Visible = true;
                nudNumeroElegido.Visible = true;
                btnElegirManual.Visible = true;
                nudNumeroBoletos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsigarAleatorios_Click( object sender, EventArgs e )
        {
            try
            {
                if ((Otorgados.Count + Int32.Parse(nudNumeroBoletos.Value.ToString()) > MAX_BOLETOS))
                {
                    throw new ArgumentOutOfRangeException("Número de boletos", $"Numero de boletos electrónicos no disponibles, quedan {(MAX_BOLETOS-Otorgados.Count)} boletos electrónicos");
                }
                ////MessageBox.Show( $"ID Participante: {idParticipante} ID Sorteo: {SorteoId}" );
                //throw new NotImplementedException( "Función no implementada" );
                Generados.Clear();
                //Otorgados.Clear();
                lbNumParticipantes.Items.Clear();

                //Otorgados = NBoleto.ObtenerNumerosOtorgados(SorteoId).ToList();
                Random NumeroParticipante = new Random();

                for (int i = 0; i < nudNumeroBoletos.Value; )
                {
                    Boleto = NumeroParticipante.Next(0, MAX_BOLETOS);

                    if (!Otorgados.Contains(Boleto) && !Generados.Contains(Boleto))
                    {
                        lbNumParticipantes.Items.Add(Boleto);
                        Generados.Add(Boleto);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElegirManual_Click( object sender, EventArgs e )
        {
            try
            {
                if ((Otorgados.Count + Int32.Parse(nudNumeroBoletos.Value.ToString()) > MAX_BOLETOS))
                {
                    throw new ArgumentOutOfRangeException("Número de boletos", $"Numero de boletos electrónicos no disponibles, quedan {(MAX_BOLETOS - Otorgados.Count)} boletos electrónicos");
                }

                if (lbNumParticipantes.Items.Count >= Int32.Parse(nudNumeroBoletos.Value.ToString()))
                {
                    MessageBox.Show("Ya ha elegido todos su numeros para participar");
                    return;
                }

                Boleto = Int32.Parse(nudNumeroElegido.Value.ToString());

                if (!Otorgados.Contains(Boleto) && !Generados.Contains(Boleto))
                {
                    errorAsignacion.Clear();
                    lbNumParticipantes.Items.Add(Boleto);
                    Generados.Add(Boleto);
                }
                else
                {
                    errorAsignacion.SetIconAlignment(nudNumeroElegido, ErrorIconAlignment.MiddleLeft);
                    errorAsignacion.SetError(nudNumeroElegido, "Número de electrónico no disponible");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(this, ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarParticipaciones_Click( object sender, EventArgs e )
        {
            try
            {
                if (Generados.Count == 0)
                {
                    return;
                }

                if (MessageBox.Show("¿Está seguro de registrar los numeros al participante seleccionado?", "Registrar participaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Boleto> BoletosGenerados = new List<Boleto>();

                    foreach (var boleto in Generados)
                    {
                        BoletosGenerados.Add(new Boleto { SorteoId = SorteoId, ParticipanteId = ParticipanteId, BoletoElectronico = boleto, CodigoValidacion = Guid.NewGuid() });
                    }

                    GenericServices<Boleto>.InsertarVarios(BoletosGenerados);
                    GenericServices<Boleto>.Guardar();
                    lbNumParticipantes.Items.Clear();
                    Generados.Clear();
                    ParticipanteId = 0;
                    nudNumeroBoletos.Value = 0;
                    nudNumeroElegido.Value = 0;
                    //rbAsignacionAutomatica.Checked = rbAsignacionAutomatica.Checked ? false : true;
                    //rbAsignacionManual.Checked = rbAsignacionManual.Checked ? false : true;
                    btnAsigarAleatorios.Visible = false;                    
                    txtParticipanteSeleccionado.Clear();
                    txtParticipanteSeleccionado.Focus();
                    cbSorteos_SelectedIndexChanged(sender, e);

                    if (Otorgados.Count == MAX_BOLETOS)
                    {
                        throw new ArgumentOutOfRangeException("Todos los boletos electrónicos han sido otorgados");                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAsignarBoletos_Load( object sender, EventArgs e )
        {
            try
            {
                txtParticipanteSeleccionado.Text = string.Empty;
                ParticipanteId = 0;

                NSorteo.LlenarCombobox(cbSorteos, "NombreSorteo", "SorteoId");
                Otorgados = NBoleto.ObtenerNumerosOtorgados(SorteoId).Select(n => n.BoletoElectronico).ToList();
                txtTotalOtorgados.Text = Otorgados.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAsignarBoletos_Enter( object sender, EventArgs e )
        {
            try
            {
                if (ParticipanteId != 0)
                {
                    Participante participante = GenericServices<Participante>.BuscarPorId(ParticipanteId);
                    txtParticipanteSeleccionado.Text = participante.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarSorteo_Click( object sender, EventArgs e )
        {
            
        }

        private void cbSorteos_SelectedIndexChanged( object sender, EventArgs e )
        {
            try
            {
                SorteoId = Int32.Parse(cbSorteos.SelectedValue.ToString());
                Sorteo sorteo = GenericServices<Sorteo>.BuscarPorId(SorteoId);

                MAX_BOLETOS = sorteo.TotalBoletos;

                Otorgados = NBoleto.ObtenerNumerosOtorgados(SorteoId).Select(n => n.BoletoElectronico).ToList();
                txtTotalOtorgados.Text = Otorgados.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
