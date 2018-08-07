namespace PracticaEduardAristizabal
{
    partial class frmIngresar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.tsmAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlanteamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbxLlave = new System.Windows.Forms.PictureBox();
            this.epvIngresar = new System.Windows.Forms.ErrorProvider(this.components);
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Location = new System.Drawing.Point(124, 298);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 33);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(74, 261);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(225, 31);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(142, 245);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAutor,
            this.tsmPlanteamiento,
            this.tsmSalir});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(390, 24);
            this.mspMenu.TabIndex = 3;
            this.mspMenu.Text = "Menu";
            // 
            // tsmAutor
            // 
            this.tsmAutor.Name = "tsmAutor";
            this.tsmAutor.Size = new System.Drawing.Size(49, 20);
            this.tsmAutor.Text = "Autor";
            this.tsmAutor.Click += new System.EventHandler(this.tsmAutor_Click);
            // 
            // tsmPlanteamiento
            // 
            this.tsmPlanteamiento.Name = "tsmPlanteamiento";
            this.tsmPlanteamiento.Size = new System.Drawing.Size(96, 20);
            this.tsmPlanteamiento.Text = "Planteamiento";
            this.tsmPlanteamiento.Click += new System.EventHandler(this.tsmPlanteamiento_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(328, 25);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Superéxito - Sistema de Inventarios";
            // 
            // pbxLlave
            // 
            this.pbxLlave.Image = global::PracticaEduardAristizabal.Properties.Resources.login;
            this.pbxLlave.Location = new System.Drawing.Point(74, 116);
            this.pbxLlave.Name = "pbxLlave";
            this.pbxLlave.Size = new System.Drawing.Size(225, 107);
            this.pbxLlave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLlave.TabIndex = 5;
            this.pbxLlave.TabStop = false;
            // 
            // epvIngresar
            // 
            this.epvIngresar.ContainerControl = this;
            // 
            // frmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.ControlBox = false;
            this.Controls.Add(this.pbxLlave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.mspMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmIngresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar al sistema";
            this.Load += new System.EventHandler(this.frmIngresar_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAutor;
        private System.Windows.Forms.ToolStripMenuItem tsmPlanteamiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxLlave;
        private System.Windows.Forms.ErrorProvider epvIngresar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
    }
}

