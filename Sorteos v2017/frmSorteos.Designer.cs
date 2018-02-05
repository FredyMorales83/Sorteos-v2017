namespace Sorteos_v2017
{
    partial class frmSorteos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreSorteo = new System.Windows.Forms.TextBox();
            this.nudTotalBoletos = new System.Windows.Forms.NumericUpDown();
            this.btnCrearSorteo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtpFechaSorteo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear nuevo sorteo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del sorteo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boletos a emitir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha a realizar el sorteo:";
            // 
            // txtNombreSorteo
            // 
            this.txtNombreSorteo.Location = new System.Drawing.Point(215, 55);
            this.txtNombreSorteo.Name = "txtNombreSorteo";
            this.txtNombreSorteo.Size = new System.Drawing.Size(365, 20);
            this.txtNombreSorteo.TabIndex = 3;
            // 
            // nudTotalBoletos
            // 
            this.nudTotalBoletos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTotalBoletos.Location = new System.Drawing.Point(215, 103);
            this.nudTotalBoletos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalBoletos.Name = "nudTotalBoletos";
            this.nudTotalBoletos.Size = new System.Drawing.Size(129, 16);
            this.nudTotalBoletos.TabIndex = 5;
            this.nudTotalBoletos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCrearSorteo
            // 
            this.btnCrearSorteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSorteo.Location = new System.Drawing.Point(585, 342);
            this.btnCrearSorteo.Name = "btnCrearSorteo";
            this.btnCrearSorteo.Size = new System.Drawing.Size(87, 57);
            this.btnCrearSorteo.TabIndex = 6;
            this.btnCrearSorteo.Text = "Crear Sorteo";
            this.btnCrearSorteo.UseVisualStyleBackColor = true;
            this.btnCrearSorteo.Click += new System.EventHandler(this.btnCrearSorteo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(493, 342);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 57);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtpFechaSorteo
            // 
            this.dtpFechaSorteo.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtpFechaSorteo.Location = new System.Drawing.Point(209, 151);
            this.dtpFechaSorteo.Name = "dtpFechaSorteo";
            this.dtpFechaSorteo.Size = new System.Drawing.Size(279, 20);
            this.dtpFechaSorteo.TabIndex = 7;
            // 
            // frmSorteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dtpFechaSorteo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCrearSorteo);
            this.Controls.Add(this.nudTotalBoletos);
            this.Controls.Add(this.txtNombreSorteo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmSorteos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Sorteo";
            this.Load += new System.EventHandler(this.frmSorteos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreSorteo;
        private System.Windows.Forms.NumericUpDown nudTotalBoletos;
        private System.Windows.Forms.Button btnCrearSorteo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaSorteo;
    }
}