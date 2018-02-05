namespace Sorteos_v2017
{
    partial class frmParticipantes
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
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.txtParticipanteABuscar = new System.Windows.Forms.TextBox();
            this.scContenedor = new System.Windows.Forms.SplitContainer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListadoParticipantes = new System.Windows.Forms.TabPage();
            this.btnOtorgarBoletos = new System.Windows.Forms.Button();
            this.lblParticipanteBuscado = new System.Windows.Forms.Label();
            this.tcParticipantes = new System.Windows.Forms.TabControl();
            this.tpMttoParticipantes = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scContenedor)).BeginInit();
            this.scContenedor.Panel1.SuspendLayout();
            this.scContenedor.Panel2.SuspendLayout();
            this.scContenedor.SuspendLayout();
            this.tpListadoParticipantes.SuspendLayout();
            this.tcParticipantes.SuspendLayout();
            this.tpMttoParticipantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipAyuda
            // 
            this.toolTipAyuda.AutomaticDelay = 100;
            this.toolTipAyuda.IsBalloon = true;
            this.toolTipAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAyuda.ToolTipTitle = "MGSoft Sorteos";
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticipantes.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(6, 47);
            this.dgvParticipantes.MultiSelect = false;
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipantes.Size = new System.Drawing.Size(562, 348);
            this.dgvParticipantes.TabIndex = 0;
            this.toolTipAyuda.SetToolTip(this.dgvParticipantes, "Doble click para editar participante");
            this.dgvParticipantes.DoubleClick += new System.EventHandler(this.dgvParticipantes_DoubleClick);
            // 
            // txtParticipanteABuscar
            // 
            this.txtParticipanteABuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParticipanteABuscar.Location = new System.Drawing.Point(127, 21);
            this.txtParticipanteABuscar.Name = "txtParticipanteABuscar";
            this.txtParticipanteABuscar.Size = new System.Drawing.Size(441, 20);
            this.txtParticipanteABuscar.TabIndex = 2;
            this.toolTipAyuda.SetToolTip(this.txtParticipanteABuscar, "Escriba el dato a buscar");
            this.txtParticipanteABuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParticipanteABuscar_KeyUp);
            // 
            // scContenedor
            // 
            this.scContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContenedor.IsSplitterFixed = true;
            this.scContenedor.Location = new System.Drawing.Point(3, 3);
            this.scContenedor.Name = "scContenedor";
            // 
            // scContenedor.Panel1
            // 
            this.scContenedor.Panel1.Controls.Add(this.btnCerrar);
            this.scContenedor.Panel1.Controls.Add(this.btnGuardar);
            this.scContenedor.Panel1.Controls.Add(this.btnNuevo);
            this.scContenedor.Panel1.Controls.Add(this.btnEditar);
            this.toolTipAyuda.SetToolTip(this.scContenedor.Panel1, "Participantes - Acciones a realizar");
            // 
            // scContenedor.Panel2
            // 
            this.scContenedor.Panel2.Controls.Add(this.txtDireccion);
            this.scContenedor.Panel2.Controls.Add(this.txtCorreoElectronico);
            this.scContenedor.Panel2.Controls.Add(this.txtCelular);
            this.scContenedor.Panel2.Controls.Add(this.txtTelefono);
            this.scContenedor.Panel2.Controls.Add(this.txtApellidoMaterno);
            this.scContenedor.Panel2.Controls.Add(this.txtApellidoPaterno);
            this.scContenedor.Panel2.Controls.Add(this.txtNombre);
            this.scContenedor.Panel2.Controls.Add(this.label7);
            this.scContenedor.Panel2.Controls.Add(this.label6);
            this.scContenedor.Panel2.Controls.Add(this.label5);
            this.scContenedor.Panel2.Controls.Add(this.label4);
            this.scContenedor.Panel2.Controls.Add(this.label3);
            this.scContenedor.Panel2.Controls.Add(this.label2);
            this.scContenedor.Panel2.Controls.Add(this.label1);
            this.toolTipAyuda.SetToolTip(this.scContenedor.Panel2, "Sorteos - Capture la información requerida");
            this.scContenedor.Size = new System.Drawing.Size(570, 429);
            this.scContenedor.SplitterDistance = 121;
            this.scContenedor.SplitterWidth = 2;
            this.scContenedor.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(13, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 65);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(13, 164);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 65);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(13, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 65);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(13, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 65);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(116, 336);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(325, 73);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(116, 283);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(246, 20);
            this.txtCorreoElectronico.TabIndex = 5;
            this.txtCorreoElectronico.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreoElectronico_Validating);
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.Location = new System.Drawing.Point(116, 230);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(246, 20);
            this.txtCelular.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(115, 177);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(246, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(115, 124);
            this.txtApellidoMaterno.MaxLength = 50;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(246, 20);
            this.txtApellidoMaterno.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(116, 71);
            this.txtApellidoPaterno.MaxLength = 50;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(246, 20);
            this.txtApellidoPaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(116, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teléfono móvil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teléfono fijo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // tpListadoParticipantes
            // 
            this.tpListadoParticipantes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpListadoParticipantes.Controls.Add(this.btnOtorgarBoletos);
            this.tpListadoParticipantes.Controls.Add(this.txtParticipanteABuscar);
            this.tpListadoParticipantes.Controls.Add(this.lblParticipanteBuscado);
            this.tpListadoParticipantes.Controls.Add(this.dgvParticipantes);
            this.tpListadoParticipantes.Location = new System.Drawing.Point(4, 22);
            this.tpListadoParticipantes.Name = "tpListadoParticipantes";
            this.tpListadoParticipantes.Padding = new System.Windows.Forms.Padding(3);
            this.tpListadoParticipantes.Size = new System.Drawing.Size(576, 435);
            this.tpListadoParticipantes.TabIndex = 0;
            this.tpListadoParticipantes.Text = "Lista de participantes";
            // 
            // btnOtorgarBoletos
            // 
            this.btnOtorgarBoletos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtorgarBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtorgarBoletos.Location = new System.Drawing.Point(476, 401);
            this.btnOtorgarBoletos.Name = "btnOtorgarBoletos";
            this.btnOtorgarBoletos.Size = new System.Drawing.Size(92, 28);
            this.btnOtorgarBoletos.TabIndex = 3;
            this.btnOtorgarBoletos.Text = "Otorgar boletos";
            this.btnOtorgarBoletos.UseVisualStyleBackColor = true;
            this.btnOtorgarBoletos.Click += new System.EventHandler(this.btnOtorgarBoletos_Click);
            // 
            // lblParticipanteBuscado
            // 
            this.lblParticipanteBuscado.AutoSize = true;
            this.lblParticipanteBuscado.Location = new System.Drawing.Point(9, 24);
            this.lblParticipanteBuscado.Name = "lblParticipanteBuscado";
            this.lblParticipanteBuscado.Size = new System.Drawing.Size(113, 13);
            this.lblParticipanteBuscado.TabIndex = 1;
            this.lblParticipanteBuscado.Text = "Participante a buscar: ";
            // 
            // tcParticipantes
            // 
            this.tcParticipantes.Controls.Add(this.tpListadoParticipantes);
            this.tcParticipantes.Controls.Add(this.tpMttoParticipantes);
            this.tcParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcParticipantes.HotTrack = true;
            this.tcParticipantes.Location = new System.Drawing.Point(0, 0);
            this.tcParticipantes.Name = "tcParticipantes";
            this.tcParticipantes.SelectedIndex = 0;
            this.tcParticipantes.Size = new System.Drawing.Size(584, 461);
            this.tcParticipantes.TabIndex = 0;
            // 
            // tpMttoParticipantes
            // 
            this.tpMttoParticipantes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpMttoParticipantes.Controls.Add(this.scContenedor);
            this.tpMttoParticipantes.Location = new System.Drawing.Point(4, 22);
            this.tpMttoParticipantes.Name = "tpMttoParticipantes";
            this.tpMttoParticipantes.Padding = new System.Windows.Forms.Padding(3);
            this.tpMttoParticipantes.Size = new System.Drawing.Size(576, 435);
            this.tpMttoParticipantes.TabIndex = 1;
            this.tpMttoParticipantes.Text = "Mantenimiento de participantes";
            // 
            // frmParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tcParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "frmParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Participantes";
            this.Load += new System.EventHandler(this.frmParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.scContenedor.Panel1.ResumeLayout(false);
            this.scContenedor.Panel2.ResumeLayout(false);
            this.scContenedor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContenedor)).EndInit();
            this.scContenedor.ResumeLayout(false);
            this.tpListadoParticipantes.ResumeLayout(false);
            this.tpListadoParticipantes.PerformLayout();
            this.tcParticipantes.ResumeLayout(false);
            this.tpMttoParticipantes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.TabPage tpListadoParticipantes;
        private System.Windows.Forms.TextBox txtParticipanteABuscar;
        private System.Windows.Forms.Label lblParticipanteBuscado;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.TabControl tcParticipantes;
        private System.Windows.Forms.TabPage tpMttoParticipantes;
        private System.Windows.Forms.SplitContainer scContenedor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnOtorgarBoletos;
    }
}