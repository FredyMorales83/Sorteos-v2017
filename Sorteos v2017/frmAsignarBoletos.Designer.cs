namespace Sorteos_v2017
{
    partial class frmAsignarBoletos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSorteos = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarSorteo = new System.Windows.Forms.Button();
            this.btnElegirParticipante = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParticipanteSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAsignacionManual = new System.Windows.Forms.RadioButton();
            this.rbAsignacionAutomatica = new System.Windows.Forms.RadioButton();
            this.lblNumAOtorgar = new System.Windows.Forms.Label();
            this.nudNumeroBoletos = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnElegirManual = new System.Windows.Forms.Button();
            this.btnAsigarAleatorios = new System.Windows.Forms.Button();
            this.txtTotalOtorgados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAsignado = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarParticipaciones = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumParticipantes = new System.Windows.Forms.ListBox();
            this.lblNumElegido = new System.Windows.Forms.Label();
            this.nudNumeroElegido = new System.Windows.Forms.NumericUpDown();
            this.errorAsignacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroBoletos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroElegido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAsignacion)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSorteos);
            this.groupBox1.Controls.Add(this.btnSeleccionarSorteo);
            this.groupBox1.Controls.Add(this.btnElegirParticipante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtParticipanteSeleccionado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir participante";
            // 
            // cbSorteos
            // 
            this.cbSorteos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSorteos.FormattingEnabled = true;
            this.cbSorteos.Location = new System.Drawing.Point(517, 30);
            this.cbSorteos.Name = "cbSorteos";
            this.cbSorteos.Size = new System.Drawing.Size(284, 21);
            this.cbSorteos.TabIndex = 4;
            this.cbSorteos.SelectedIndexChanged += new System.EventHandler(this.cbSorteos_SelectedIndexChanged);
            // 
            // btnSeleccionarSorteo
            // 
            this.btnSeleccionarSorteo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeleccionarSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarSorteo.Location = new System.Drawing.Point(807, 22);
            this.btnSeleccionarSorteo.Name = "btnSeleccionarSorteo";
            this.btnSeleccionarSorteo.Size = new System.Drawing.Size(87, 45);
            this.btnSeleccionarSorteo.TabIndex = 1;
            this.btnSeleccionarSorteo.Text = "Seleccionar sorteo";
            this.btnSeleccionarSorteo.UseVisualStyleBackColor = true;
            this.btnSeleccionarSorteo.Click += new System.EventHandler(this.btnSeleccionarSorteo_Click);
            // 
            // btnElegirParticipante
            // 
            this.btnElegirParticipante.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnElegirParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirParticipante.Location = new System.Drawing.Point(377, 22);
            this.btnElegirParticipante.Name = "btnElegirParticipante";
            this.btnElegirParticipante.Size = new System.Drawing.Size(87, 45);
            this.btnElegirParticipante.TabIndex = 1;
            this.btnElegirParticipante.Text = "Elegir participante...";
            this.btnElegirParticipante.UseVisualStyleBackColor = true;
            this.btnElegirParticipante.Click += new System.EventHandler(this.btnElegirParticipante_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorteo:";
            // 
            // txtParticipanteSeleccionado
            // 
            this.txtParticipanteSeleccionado.Location = new System.Drawing.Point(87, 34);
            this.txtParticipanteSeleccionado.Name = "txtParticipanteSeleccionado";
            this.txtParticipanteSeleccionado.Size = new System.Drawing.Size(284, 20);
            this.txtParticipanteSeleccionado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Participante: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAsignacionManual);
            this.groupBox2.Controls.Add(this.rbAsignacionAutomatica);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elija método de asignación";
            // 
            // rbAsignacionManual
            // 
            this.rbAsignacionManual.AutoSize = true;
            this.rbAsignacionManual.Location = new System.Drawing.Point(106, 31);
            this.rbAsignacionManual.Name = "rbAsignacionManual";
            this.rbAsignacionManual.Size = new System.Drawing.Size(60, 17);
            this.rbAsignacionManual.TabIndex = 1;
            this.rbAsignacionManual.TabStop = true;
            this.rbAsignacionManual.Text = "Manual";
            this.rbAsignacionManual.UseVisualStyleBackColor = true;
            this.rbAsignacionManual.CheckedChanged += new System.EventHandler(this.rbAsignacionManual_CheckedChanged);
            // 
            // rbAsignacionAutomatica
            // 
            this.rbAsignacionAutomatica.AutoSize = true;
            this.rbAsignacionAutomatica.Location = new System.Drawing.Point(15, 31);
            this.rbAsignacionAutomatica.Name = "rbAsignacionAutomatica";
            this.rbAsignacionAutomatica.Size = new System.Drawing.Size(78, 17);
            this.rbAsignacionAutomatica.TabIndex = 0;
            this.rbAsignacionAutomatica.TabStop = true;
            this.rbAsignacionAutomatica.Text = "Automática";
            this.rbAsignacionAutomatica.UseVisualStyleBackColor = true;
            this.rbAsignacionAutomatica.CheckedChanged += new System.EventHandler(this.rbAsignacionAutomatica_CheckedChanged);
            // 
            // lblNumAOtorgar
            // 
            this.lblNumAOtorgar.AutoSize = true;
            this.lblNumAOtorgar.Location = new System.Drawing.Point(12, 39);
            this.lblNumAOtorgar.Name = "lblNumAOtorgar";
            this.lblNumAOtorgar.Size = new System.Drawing.Size(100, 13);
            this.lblNumAOtorgar.TabIndex = 0;
            this.lblNumAOtorgar.Text = "# Boletos a otorgar:";
            // 
            // nudNumeroBoletos
            // 
            this.nudNumeroBoletos.Location = new System.Drawing.Point(115, 35);
            this.nudNumeroBoletos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNumeroBoletos.Name = "nudNumeroBoletos";
            this.nudNumeroBoletos.Size = new System.Drawing.Size(165, 20);
            this.nudNumeroBoletos.TabIndex = 0;
            this.nudNumeroBoletos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnElegirManual);
            this.groupBox3.Controls.Add(this.btnAsigarAleatorios);
            this.groupBox3.Controls.Add(this.txtTotalOtorgados);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpFechaAsignado);
            this.groupBox3.Controls.Add(this.btnGuardarParticipaciones);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbNumParticipantes);
            this.groupBox3.Controls.Add(this.lblNumElegido);
            this.groupBox3.Controls.Add(this.lblNumAOtorgar);
            this.groupBox3.Controls.Add(this.nudNumeroElegido);
            this.groupBox3.Controls.Add(this.nudNumeroBoletos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 416);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignar boletos para participar";
            // 
            // btnElegirManual
            // 
            this.btnElegirManual.Location = new System.Drawing.Point(283, 66);
            this.btnElegirManual.Name = "btnElegirManual";
            this.btnElegirManual.Size = new System.Drawing.Size(128, 23);
            this.btnElegirManual.TabIndex = 3;
            this.btnElegirManual.Text = "Elegir número";
            this.btnElegirManual.UseVisualStyleBackColor = true;
            this.btnElegirManual.Visible = false;
            this.btnElegirManual.Click += new System.EventHandler(this.btnElegirManual_Click);
            // 
            // btnAsigarAleatorios
            // 
            this.btnAsigarAleatorios.Location = new System.Drawing.Point(283, 34);
            this.btnAsigarAleatorios.Name = "btnAsigarAleatorios";
            this.btnAsigarAleatorios.Size = new System.Drawing.Size(128, 23);
            this.btnAsigarAleatorios.TabIndex = 1;
            this.btnAsigarAleatorios.Text = "Asignación automática";
            this.btnAsigarAleatorios.UseVisualStyleBackColor = true;
            this.btnAsigarAleatorios.Visible = false;
            this.btnAsigarAleatorios.Click += new System.EventHandler(this.btnAsigarAleatorios_Click);
            // 
            // txtTotalOtorgados
            // 
            this.txtTotalOtorgados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalOtorgados.Enabled = false;
            this.txtTotalOtorgados.Location = new System.Drawing.Point(240, 351);
            this.txtTotalOtorgados.Name = "txtTotalOtorgados";
            this.txtTotalOtorgados.Size = new System.Drawing.Size(100, 20);
            this.txtTotalOtorgados.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total de participaciones otorgadas (General): ";
            // 
            // dtpFechaAsignado
            // 
            this.dtpFechaAsignado.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtpFechaAsignado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaAsignado.Location = new System.Drawing.Point(130, 328);
            this.dtpFechaAsignado.Name = "dtpFechaAsignado";
            this.dtpFechaAsignado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAsignado.TabIndex = 18;
            // 
            // btnGuardarParticipaciones
            // 
            this.btnGuardarParticipaciones.Location = new System.Drawing.Point(336, 327);
            this.btnGuardarParticipaciones.Name = "btnGuardarParticipaciones";
            this.btnGuardarParticipaciones.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarParticipaciones.TabIndex = 17;
            this.btnGuardarParticipaciones.Text = "Guardar";
            this.btnGuardarParticipaciones.UseVisualStyleBackColor = true;
            this.btnGuardarParticipaciones.Click += new System.EventHandler(this.btnGuardarParticipaciones_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de asignación: ";
            // 
            // lbNumParticipantes
            // 
            this.lbNumParticipantes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumParticipantes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNumParticipantes.FormattingEnabled = true;
            this.lbNumParticipantes.ItemHeight = 18;
            this.lbNumParticipantes.Location = new System.Drawing.Point(15, 97);
            this.lbNumParticipantes.Name = "lbNumParticipantes";
            this.lbNumParticipantes.Size = new System.Drawing.Size(396, 220);
            this.lbNumParticipantes.Sorted = true;
            this.lbNumParticipantes.TabIndex = 4;
            // 
            // lblNumElegido
            // 
            this.lblNumElegido.AutoSize = true;
            this.lblNumElegido.Location = new System.Drawing.Point(12, 71);
            this.lblNumElegido.Name = "lblNumElegido";
            this.lblNumElegido.Size = new System.Drawing.Size(84, 13);
            this.lblNumElegido.TabIndex = 0;
            this.lblNumElegido.Text = "Número elegido:";
            this.lblNumElegido.Visible = false;
            // 
            // nudNumeroElegido
            // 
            this.nudNumeroElegido.Location = new System.Drawing.Point(115, 67);
            this.nudNumeroElegido.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNumeroElegido.Name = "nudNumeroElegido";
            this.nudNumeroElegido.Size = new System.Drawing.Size(165, 20);
            this.nudNumeroElegido.TabIndex = 2;
            this.nudNumeroElegido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumeroElegido.Visible = false;
            // 
            // errorAsignacion
            // 
            this.errorAsignacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorAsignacion.ContainerControl = this;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "Progreso";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeftLayout = true;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmAsignarBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(909, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(925, 600);
            this.Name = "frmAsignarBoletos";
            this.Text = "frmAsignarBoletos";
            this.Load += new System.EventHandler(this.frmAsignarBoletos_Load);
            this.Enter += new System.EventHandler(this.frmAsignarBoletos_Enter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroBoletos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroElegido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAsignacion)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParticipanteSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElegirParticipante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAsignacionManual;
        private System.Windows.Forms.RadioButton rbAsignacionAutomatica;
        private System.Windows.Forms.Label lblNumAOtorgar;
        private System.Windows.Forms.NumericUpDown nudNumeroBoletos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalOtorgados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignado;
        private System.Windows.Forms.Button btnGuardarParticipaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbNumParticipantes;
        private System.Windows.Forms.Label lblNumElegido;
        private System.Windows.Forms.Button btnElegirManual;
        private System.Windows.Forms.Button btnAsigarAleatorios;
        private System.Windows.Forms.NumericUpDown nudNumeroElegido;
        private System.Windows.Forms.Button btnSeleccionarSorteo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSorteos;
        private System.Windows.Forms.ErrorProvider errorAsignacion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}