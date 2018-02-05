namespace Sorteos_v2017
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoSorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otorgarBoletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisParticipacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivioToolStripMenuItem,
            this.sortepsToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivioToolStripMenuItem
            // 
            this.archivioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivioToolStripMenuItem.Name = "archivioToolStripMenuItem";
            this.archivioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivioToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // sortepsToolStripMenuItem
            // 
            this.sortepsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoSorteoToolStripMenuItem,
            this.listaDeSorteosToolStripMenuItem,
            this.otorgarBoletosToolStripMenuItem});
            this.sortepsToolStripMenuItem.Name = "sortepsToolStripMenuItem";
            this.sortepsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sortepsToolStripMenuItem.Text = "&Sorteos";
            // 
            // nuevoSorteoToolStripMenuItem
            // 
            this.nuevoSorteoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.nuevoSorteoToolStripMenuItem.Name = "nuevoSorteoToolStripMenuItem";
            this.nuevoSorteoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoSorteoToolStripMenuItem.Text = "&Nuevo sorteo";
            this.nuevoSorteoToolStripMenuItem.Click += new System.EventHandler(this.nuevoSorteoToolStripMenuItem_Click);
            // 
            // listaDeSorteosToolStripMenuItem
            // 
            this.listaDeSorteosToolStripMenuItem.Name = "listaDeSorteosToolStripMenuItem";
            this.listaDeSorteosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeSorteosToolStripMenuItem.Text = "&Lista de sorteos";
            this.listaDeSorteosToolStripMenuItem.Click += new System.EventHandler(this.listaDeSorteosToolStripMenuItem_Click);
            // 
            // otorgarBoletosToolStripMenuItem
            // 
            this.otorgarBoletosToolStripMenuItem.Name = "otorgarBoletosToolStripMenuItem";
            this.otorgarBoletosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.otorgarBoletosToolStripMenuItem.Text = "&Otorgar boletos";
            this.otorgarBoletosToolStripMenuItem.Click += new System.EventHandler(this.otorgarBoletosToolStripMenuItem_Click);
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.verMisParticipacionesToolStripMenuItem});
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.participantesToolStripMenuItem.Text = "&Participantes";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarToolStripMenuItem.Text = "&Administrar participantes";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // verMisParticipacionesToolStripMenuItem
            // 
            this.verMisParticipacionesToolStripMenuItem.Name = "verMisParticipacionesToolStripMenuItem";
            this.verMisParticipacionesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.verMisParticipacionesToolStripMenuItem.Text = "&Ver Mis Participaciones";
            this.verMisParticipacionesToolStripMenuItem.Click += new System.EventHandler(this.verMisParticipacionesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instruccionesToolStripMenuItem.Text = "&Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 480);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(927, 519);
            this.Name = "frmPrincipal";
            this.Text = "Sorteos V2017.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoSorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisParticipacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otorgarBoletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}