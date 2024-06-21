namespace Pav.Ut3.Tp5.Vistas
{
    partial class pnlSector
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNroSector = new Label();
            lblEspecies = new Label();
            lblCantAnimales = new Label();
            lblUbicacion = new Label();
            lblEmpleado = new Label();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lblNroSector
            // 
            lblNroSector.FlatStyle = FlatStyle.System;
            lblNroSector.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroSector.ForeColor = Color.White;
            lblNroSector.Location = new Point(0, 0);
            lblNroSector.Name = "lblNroSector";
            lblNroSector.Size = new Size(255, 63);
            lblNroSector.TabIndex = 0;
            lblNroSector.Text = "0";
            lblNroSector.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEspecies
            // 
            lblEspecies.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEspecies.Location = new Point(3, 63);
            lblEspecies.Name = "lblEspecies";
            lblEspecies.Size = new Size(252, 68);
            lblEspecies.TabIndex = 1;
            lblEspecies.Text = "Especies";
            lblEspecies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantAnimales
            // 
            lblCantAnimales.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCantAnimales.Location = new Point(0, 131);
            lblCantAnimales.Name = "lblCantAnimales";
            lblCantAnimales.Size = new Size(252, 60);
            lblCantAnimales.TabIndex = 2;
            lblCantAnimales.Text = "0";
            lblCantAnimales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUbicacion
            // 
            lblUbicacion.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(3, 253);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(249, 57);
            lblUbicacion.TabIndex = 3;
            lblUbicacion.Text = "Ubicacion";
            lblUbicacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpleado
            // 
            lblEmpleado.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(0, 191);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(255, 62);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado";
            lblEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(83, 331);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click_1;
            // 
            // pnlSector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(btnVer);
            Controls.Add(lblEmpleado);
            Controls.Add(lblUbicacion);
            Controls.Add(lblCantAnimales);
            Controls.Add(lblEspecies);
            Controls.Add(lblNroSector);
            Name = "pnlSector";
            Size = new Size(255, 363);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNroSector;
        private Label lblEspecies;
        private Label lblCantAnimales;
        private Label lblUbicacion;
        private Label lblEmpleado;
        private Button btnVer;
    }
}
