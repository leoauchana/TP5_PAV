namespace Pav.Ut3.Tp5.Vistas
{
    partial class DetalleSectorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvEspecies = new DataGridView();
            Especie = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            sectoresBindingSource = new BindingSource(components);
            repositorioBindingSource = new BindingSource(components);
            lblSectorNumero = new Label();
            lblNumSector = new Label();
            lblEmpleado = new Label();
            lblNomEmpleado = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEspecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sectoresBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositorioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvEspecies
            // 
            dgvEspecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecies.Columns.AddRange(new DataGridViewColumn[] { Especie, Edad, Peso, Pais });
            dgvEspecies.Location = new Point(136, 135);
            dgvEspecies.Name = "dgvEspecies";
            dgvEspecies.RowHeadersWidth = 51;
            dgvEspecies.RowTemplate.Height = 29;
            dgvEspecies.Size = new Size(550, 242);
            dgvEspecies.TabIndex = 0;
            // 
            // Especie
            // 
            Especie.HeaderText = "Especie";
            Especie.MinimumWidth = 6;
            Especie.Name = "Especie";
            Especie.Width = 125;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.Width = 125;
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.MinimumWidth = 6;
            Peso.Name = "Peso";
            Peso.Width = 125;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.MinimumWidth = 6;
            Pais.Name = "Pais";
            Pais.Width = 125;
            // 
            // sectoresBindingSource
            // 
            sectoresBindingSource.DataMember = "Sectores";
            sectoresBindingSource.DataSource = repositorioBindingSource;
            // 
            // repositorioBindingSource
            // 
            repositorioBindingSource.DataSource = typeof(Persistencia.Repositorio);
            // 
            // lblSectorNumero
            // 
            lblSectorNumero.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSectorNumero.Location = new Point(136, 45);
            lblSectorNumero.Name = "lblSectorNumero";
            lblSectorNumero.Size = new Size(118, 42);
            lblSectorNumero.TabIndex = 1;
            lblSectorNumero.Text = "Sector:";
            // 
            // lblNumSector
            // 
            lblNumSector.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNumSector.Location = new Point(247, 45);
            lblNumSector.Name = "lblNumSector";
            lblNumSector.Size = new Size(63, 42);
            lblNumSector.TabIndex = 2;
            lblNumSector.Text = "0";
            // 
            // lblEmpleado
            // 
            lblEmpleado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(400, 50);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(179, 37);
            lblEmpleado.TabIndex = 3;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblNomEmpleado
            // 
            lblNomEmpleado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNomEmpleado.Location = new Point(570, 50);
            lblNomEmpleado.Name = "lblNomEmpleado";
            lblNomEmpleado.Size = new Size(132, 42);
            lblNomEmpleado.TabIndex = 4;
            lblNomEmpleado.Text = "nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(376, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // DetalleSectorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(btnCancelar);
            Controls.Add(lblNomEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(lblNumSector);
            Controls.Add(lblSectorNumero);
            Controls.Add(dgvEspecies);
            Name = "DetalleSectorView";
            Text = "DetalleSectorView";
            ((System.ComponentModel.ISupportInitialize)dgvEspecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)sectoresBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositorioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEspecies;
        private Label lblSectorNumero;
        private Label lblNumSector;
        private Label lblEmpleado;
        private Label lblNomEmpleado;
        private BindingSource repositorioBindingSource;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Pais;
        private BindingSource sectoresBindingSource;
        private Button btnCancelar;
    }
}