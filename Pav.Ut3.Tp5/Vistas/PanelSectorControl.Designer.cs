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
            lblNroSector.Location = new Point(0, 14);
            lblNroSector.Name = "lblNroSector";
            lblNroSector.Size = new Size(204, 28);
            lblNroSector.TabIndex = 0;
            lblNroSector.Text = "0";
            lblNroSector.TextAlign = ContentAlignment.MiddleCenter;
            lblNroSector.UseWaitCursor = true;
            // 
            // lblEspecies
            // 
            lblEspecies.Location = new Point(3, 42);
            lblEspecies.Name = "lblEspecies";
            lblEspecies.Size = new Size(201, 50);
            lblEspecies.TabIndex = 1;
            lblEspecies.Text = "Especies";
            lblEspecies.TextAlign = ContentAlignment.MiddleCenter;
            lblEspecies.UseWaitCursor = true;
            // 
            // lblCantAnimales
            // 
            lblCantAnimales.Location = new Point(3, 92);
            lblCantAnimales.Name = "lblCantAnimales";
            lblCantAnimales.Size = new Size(201, 36);
            lblCantAnimales.TabIndex = 2;
            lblCantAnimales.Text = "0";
            lblCantAnimales.TextAlign = ContentAlignment.MiddleCenter;
            lblCantAnimales.UseWaitCursor = true;
            // 
            // lblUbicacion
            // 
            lblUbicacion.ImageAlign = ContentAlignment.MiddleLeft;
            lblUbicacion.Location = new Point(6, 182);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(198, 57);
            lblUbicacion.TabIndex = 3;
            lblUbicacion.Text = "Ubicacion";
            lblUbicacion.TextAlign = ContentAlignment.MiddleCenter;
            lblUbicacion.UseWaitCursor = true;
            // 
            // lblEmpleado
            // 
            lblEmpleado.Location = new Point(0, 128);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(204, 54);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado";
            lblEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            lblEmpleado.UseWaitCursor = true;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(53, 254);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(94, 29);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.UseWaitCursor = true;
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
            Size = new Size(204, 283);
            UseWaitCursor = true;
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
