namespace Sorteos_v2017
{
    partial class frmListarSorteos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarParticipante = new System.Windows.Forms.TextBox();
            this.btnGenerarPdfParticipante = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerarPdfSorteo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoletosDisponibles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoletosEmitidos = new System.Windows.Forms.TextBox();
            this.cbSorteos = new System.Windows.Forms.ComboBox();
            this.panelGanador = new System.Windows.Forms.Panel();
            this.txtNumSorteoReferencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveWinner = new System.Windows.Forms.Button();
            this.txtEnlaceVerificacion = new System.Windows.Forms.TextBox();
            this.cbSorteoRef = new System.Windows.Forms.ComboBox();
            this.lnkVerificacion = new System.Windows.Forms.LinkLabel();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.txtNumGanador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvParticipantesBoletos = new System.Windows.Forms.ListView();
            this.chBoleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValidador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.epListarSorteos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelGanador.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epListarSorteos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de sorteos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBuscarParticipante);
            this.panel1.Controls.Add(this.btnGenerarPdfParticipante);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelGanador);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 485);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buscar:";
            // 
            // txtBuscarParticipante
            // 
            this.txtBuscarParticipante.Location = new System.Drawing.Point(54, 156);
            this.txtBuscarParticipante.Name = "txtBuscarParticipante";
            this.txtBuscarParticipante.Size = new System.Drawing.Size(246, 20);
            this.txtBuscarParticipante.TabIndex = 9;
            this.txtBuscarParticipante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarParticipante_KeyUp);
            // 
            // btnGenerarPdfParticipante
            // 
            this.btnGenerarPdfParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPdfParticipante.Location = new System.Drawing.Point(306, 153);
            this.btnGenerarPdfParticipante.Name = "btnGenerarPdfParticipante";
            this.btnGenerarPdfParticipante.Size = new System.Drawing.Size(230, 26);
            this.btnGenerarPdfParticipante.TabIndex = 8;
            this.btnGenerarPdfParticipante.Text = "Generar lista del participante seleccionado";
            this.btnGenerarPdfParticipante.UseVisualStyleBackColor = true;
            this.btnGenerarPdfParticipante.Click += new System.EventHandler(this.btnGenerarPdfParticipante_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerarPdfSorteo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBoletosDisponibles);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBoletosEmitidos);
            this.panel3.Controls.Add(this.cbSorteos);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 140);
            this.panel3.TabIndex = 6;
            // 
            // btnGenerarPdfSorteo
            // 
            this.btnGenerarPdfSorteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarPdfSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPdfSorteo.Location = new System.Drawing.Point(301, 76);
            this.btnGenerarPdfSorteo.Name = "btnGenerarPdfSorteo";
            this.btnGenerarPdfSorteo.Size = new System.Drawing.Size(106, 53);
            this.btnGenerarPdfSorteo.TabIndex = 7;
            this.btnGenerarPdfSorteo.Text = "Generar lista del sorteo";
            this.btnGenerarPdfSorteo.UseVisualStyleBackColor = true;
            this.btnGenerarPdfSorteo.Click += new System.EventHandler(this.btnImprimirListaParticipantes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorteo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Boletos emitidos:";
            // 
            // txtBoletosDisponibles
            // 
            this.txtBoletosDisponibles.Location = new System.Drawing.Point(131, 109);
            this.txtBoletosDisponibles.Name = "txtBoletosDisponibles";
            this.txtBoletosDisponibles.ReadOnly = true;
            this.txtBoletosDisponibles.Size = new System.Drawing.Size(164, 20);
            this.txtBoletosDisponibles.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Boletos disponibles:";
            // 
            // txtBoletosEmitidos
            // 
            this.txtBoletosEmitidos.Location = new System.Drawing.Point(131, 76);
            this.txtBoletosEmitidos.Name = "txtBoletosEmitidos";
            this.txtBoletosEmitidos.ReadOnly = true;
            this.txtBoletosEmitidos.Size = new System.Drawing.Size(164, 20);
            this.txtBoletosEmitidos.TabIndex = 1;
            // 
            // cbSorteos
            // 
            this.cbSorteos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSorteos.FormattingEnabled = true;
            this.cbSorteos.Location = new System.Drawing.Point(131, 42);
            this.cbSorteos.Name = "cbSorteos";
            this.cbSorteos.Size = new System.Drawing.Size(397, 21);
            this.cbSorteos.TabIndex = 0;
            this.cbSorteos.SelectedIndexChanged += new System.EventHandler(this.cbSorteos_SelectedIndexChanged);
            // 
            // panelGanador
            // 
            this.panelGanador.Controls.Add(this.txtNumSorteoReferencia);
            this.panelGanador.Controls.Add(this.label12);
            this.panelGanador.Controls.Add(this.btnSaveWinner);
            this.panelGanador.Controls.Add(this.txtEnlaceVerificacion);
            this.panelGanador.Controls.Add(this.cbSorteoRef);
            this.panelGanador.Controls.Add(this.lnkVerificacion);
            this.panelGanador.Controls.Add(this.txtGanador);
            this.panelGanador.Controls.Add(this.txtNumGanador);
            this.panelGanador.Controls.Add(this.label11);
            this.panelGanador.Controls.Add(this.label10);
            this.panelGanador.Controls.Add(this.label9);
            this.panelGanador.Controls.Add(this.label8);
            this.panelGanador.Controls.Add(this.label7);
            this.panelGanador.Location = new System.Drawing.Point(542, 8);
            this.panelGanador.Name = "panelGanador";
            this.panelGanador.Size = new System.Drawing.Size(481, 171);
            this.panelGanador.TabIndex = 5;
            this.panelGanador.Visible = false;
            // 
            // txtNumSorteoReferencia
            // 
            this.txtNumSorteoReferencia.Location = new System.Drawing.Point(118, 73);
            this.txtNumSorteoReferencia.Name = "txtNumSorteoReferencia";
            this.txtNumSorteoReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumSorteoReferencia.TabIndex = 4;
            this.txtNumSorteoReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumSorteoReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            this.txtNumSorteoReferencia.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumSorteoReferencia_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "No. De Sorteo Referencia";
            // 
            // btnSaveWinner
            // 
            this.btnSaveWinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveWinner.Location = new System.Drawing.Point(396, 145);
            this.btnSaveWinner.Name = "btnSaveWinner";
            this.btnSaveWinner.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWinner.TabIndex = 6;
            this.btnSaveWinner.Text = "Registrar Ganador";
            this.btnSaveWinner.UseVisualStyleBackColor = true;
            this.btnSaveWinner.Click += new System.EventHandler(this.btnSaveWinner_Click);
            // 
            // txtEnlaceVerificacion
            // 
            this.txtEnlaceVerificacion.Location = new System.Drawing.Point(131, 124);
            this.txtEnlaceVerificacion.Name = "txtEnlaceVerificacion";
            this.txtEnlaceVerificacion.Size = new System.Drawing.Size(340, 20);
            this.txtEnlaceVerificacion.TabIndex = 10;
            this.txtEnlaceVerificacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnlaceVerificacion_Validating);
            // 
            // cbSorteoRef
            // 
            this.cbSorteoRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSorteoRef.FormattingEnabled = true;
            this.cbSorteoRef.Location = new System.Drawing.Point(130, 27);
            this.cbSorteoRef.Name = "cbSorteoRef";
            this.cbSorteoRef.Size = new System.Drawing.Size(341, 21);
            this.cbSorteoRef.TabIndex = 3;
            // 
            // lnkVerificacion
            // 
            this.lnkVerificacion.AutoSize = true;
            this.lnkVerificacion.Location = new System.Drawing.Point(287, 150);
            this.lnkVerificacion.Name = "lnkVerificacion";
            this.lnkVerificacion.Size = new System.Drawing.Size(103, 13);
            this.lnkVerificacion.TabIndex = 8;
            this.lnkVerificacion.TabStop = true;
            this.lnkVerificacion.Text = "Verificar Información";
            this.lnkVerificacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerificacion_LinkClicked);
            // 
            // txtGanador
            // 
            this.txtGanador.Location = new System.Drawing.Point(82, 99);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.ReadOnly = true;
            this.txtGanador.Size = new System.Drawing.Size(389, 20);
            this.txtGanador.TabIndex = 7;
            // 
            // txtNumGanador
            // 
            this.txtNumGanador.Location = new System.Drawing.Point(261, 73);
            this.txtNumGanador.Name = "txtNumGanador";
            this.txtNumGanador.Size = new System.Drawing.Size(117, 20);
            this.txtNumGanador.TabIndex = 5;
            this.txtNumGanador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumGanador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            this.txtNumGanador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumGanador_KeyUp);
            this.txtNumGanador.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumGanador_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Participante: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(132, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "GANADOR DEL SORTEO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Enlace De Verificación: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Número Ganador: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sorteo De Referencia: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lvParticipantesBoletos);
            this.panel2.Controls.Add(this.dgvParticipantes);
            this.panel2.Location = new System.Drawing.Point(5, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 297);
            this.panel2.TabIndex = 2;
            // 
            // lvParticipantesBoletos
            // 
            this.lvParticipantesBoletos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvParticipantesBoletos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvParticipantesBoletos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvParticipantesBoletos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBoleto,
            this.chValidador});
            this.lvParticipantesBoletos.FullRowSelect = true;
            this.lvParticipantesBoletos.GridLines = true;
            this.lvParticipantesBoletos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvParticipantesBoletos.LabelWrap = false;
            this.lvParticipantesBoletos.Location = new System.Drawing.Point(537, 4);
            this.lvParticipantesBoletos.MultiSelect = false;
            this.lvParticipantesBoletos.Name = "lvParticipantesBoletos";
            this.lvParticipantesBoletos.Size = new System.Drawing.Size(486, 287);
            this.lvParticipantesBoletos.TabIndex = 1;
            this.lvParticipantesBoletos.UseCompatibleStateImageBehavior = false;
            this.lvParticipantesBoletos.View = System.Windows.Forms.View.Details;
            // 
            // chBoleto
            // 
            this.chBoleto.Text = "Número boleto electrónico";
            this.chBoleto.Width = 138;
            // 
            // chValidador
            // 
            this.chValidador.Text = "Código validador";
            this.chValidador.Width = 341;
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            this.dgvParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvParticipantes.Location = new System.Drawing.Point(0, 4);
            this.dgvParticipantes.MultiSelect = false;
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.ReadOnly = true;
            this.dgvParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipantes.Size = new System.Drawing.Size(531, 287);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartXSorteo_CellClick);
            // 
            // epListarSorteos
            // 
            this.epListarSorteos.ContainerControl = this;
            // 
            // frmListarSorteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "frmListarSorteos";
            this.Text = "frmListarSorteos";
            this.Load += new System.EventHandler(this.frmListarSorteos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelGanador.ResumeLayout(false);
            this.panelGanador.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epListarSorteos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoletosDisponibles;
        private System.Windows.Forms.TextBox txtBoletosEmitidos;
        private System.Windows.Forms.ComboBox cbSorteos;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Panel panelGanador;
        private System.Windows.Forms.TextBox txtNumSorteoReferencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveWinner;
        private System.Windows.Forms.TextBox txtEnlaceVerificacion;
        private System.Windows.Forms.ComboBox cbSorteoRef;
        private System.Windows.Forms.LinkLabel lnkVerificacion;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.TextBox txtNumGanador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerarPdfSorteo;
        private System.Windows.Forms.ListView lvParticipantesBoletos;
        private System.Windows.Forms.ColumnHeader chBoleto;
        private System.Windows.Forms.ColumnHeader chValidador;
        private System.Windows.Forms.ErrorProvider epListarSorteos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarParticipante;
        private System.Windows.Forms.Button btnGenerarPdfParticipante;
    }
}