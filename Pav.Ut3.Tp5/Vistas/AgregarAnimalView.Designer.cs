namespace Pav.Ut3.Tp5.Vistas
{
    partial class AgregarAnimalView
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            tlp = new TableLayoutPanel();
            txtPeso = new TextBox();
            cbPais = new ComboBox();
            paisBindingSource = new BindingSource(components);
            txtEspecie = new Label();
            cbEspecie = new ComboBox();
            especieBindingSource = new BindingSource(components);
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblPais = new Label();
            lblPeso = new Label();
            lblSectores = new Label();
            clbSectores = new CheckedListBox();
            pBontones = new Panel();
            btCancelar = new Button();
            btAgregar = new Button();
            tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).BeginInit();
            pBontones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AccessibleDescription = "";
            lblNombre.AutoSize = true;
            tlp.SetColumnSpan(lblNombre, 3);
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(23, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(736, 42);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            tlp.SetColumnSpan(txtNombre, 3);
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.Location = new Point(23, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(736, 34);
            txtNombre.TabIndex = 1;
            // 
            // tlp
            // 
            tlp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp.AutoSize = true;
            tlp.ColumnCount = 5;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp.Controls.Add(txtPeso, 3, 6);
            tlp.Controls.Add(cbPais, 1, 6);
            tlp.Controls.Add(lblNombre, 1, 1);
            tlp.Controls.Add(txtNombre, 1, 2);
            tlp.Controls.Add(txtEspecie, 1, 3);
            tlp.Controls.Add(cbEspecie, 1, 4);
            tlp.Controls.Add(lblEdad, 3, 3);
            tlp.Controls.Add(txtEdad, 3, 4);
            tlp.Controls.Add(lblPais, 1, 5);
            tlp.Controls.Add(lblPeso, 3, 5);
            tlp.Controls.Add(lblSectores, 1, 7);
            tlp.Controls.Add(clbSectores, 1, 8);
            tlp.Controls.Add(pBontones, 3, 8);
            tlp.Location = new Point(0, 0);
            tlp.Name = "tlp";
            tlp.RowCount = 10;
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp.Size = new Size(782, 575);
            tlp.TabIndex = 2;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.Silver;
            txtPeso.Dock = DockStyle.Fill;
            txtPeso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPeso.Location = new Point(404, 233);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(355, 34);
            txtPeso.TabIndex = 9;
            // 
            // cbPais
            // 
            cbPais.BackColor = Color.Silver;
            cbPais.DataSource = paisBindingSource;
            cbPais.DisplayMember = "Nombre";
            cbPais.Dock = DockStyle.Fill;
            cbPais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(23, 233);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(355, 36);
            cbPais.TabIndex = 8;
            cbPais.ValueMember = "Cod";
            // 
            // paisBindingSource
            // 
            paisBindingSource.DataSource = typeof(Modelo.Pais);
            // 
            // txtEspecie
            // 
            txtEspecie.AutoSize = true;
            txtEspecie.Dock = DockStyle.Fill;
            txtEspecie.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtEspecie.Location = new Point(23, 104);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(355, 42);
            txtEspecie.TabIndex = 2;
            txtEspecie.Text = "Especie";
            txtEspecie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbEspecie
            // 
            cbEspecie.BackColor = Color.Silver;
            cbEspecie.DataSource = especieBindingSource;
            cbEspecie.DisplayMember = "Nombre";
            cbEspecie.Dock = DockStyle.Fill;
            cbEspecie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Location = new Point(23, 149);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(355, 36);
            cbEspecie.TabIndex = 3;
            cbEspecie.ValueMember = "Codigo";
            cbEspecie.SelectedIndexChanged += cbEspecie_SelectedIndexChanged;
            // 
            // especieBindingSource
            // 
            especieBindingSource.DataSource = typeof(Modelo.Especie);
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Dock = DockStyle.Fill;
            lblEdad.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.Location = new Point(404, 104);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(355, 42);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            lblEdad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.Silver;
            txtEdad.Dock = DockStyle.Fill;
            txtEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtEdad.Location = new Point(404, 149);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(355, 34);
            txtEdad.TabIndex = 5;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Dock = DockStyle.Fill;
            lblPais.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPais.Location = new Point(23, 188);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(355, 42);
            lblPais.TabIndex = 6;
            lblPais.Text = "Pais de Origen";
            lblPais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Dock = DockStyle.Fill;
            lblPeso.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(404, 188);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(355, 42);
            lblPeso.TabIndex = 7;
            lblPeso.Text = "Peso";
            lblPeso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSectores
            // 
            lblSectores.AutoSize = true;
            lblSectores.Dock = DockStyle.Fill;
            lblSectores.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSectores.Location = new Point(23, 272);
            lblSectores.Name = "lblSectores";
            lblSectores.Size = new Size(355, 42);
            lblSectores.TabIndex = 10;
            lblSectores.Text = "Sectores";
            lblSectores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clbSectores
            // 
            clbSectores.Dock = DockStyle.Fill;
            clbSectores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            clbSectores.FormattingEnabled = true;
            clbSectores.Location = new Point(23, 317);
            clbSectores.Name = "clbSectores";
            clbSectores.Size = new Size(355, 234);
            clbSectores.TabIndex = 11;
            // 
            // pBontones
            // 
            pBontones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBontones.Controls.Add(btCancelar);
            pBontones.Controls.Add(btAgregar);
            pBontones.Location = new Point(404, 317);
            pBontones.Name = "pBontones";
            pBontones.Size = new Size(355, 234);
            pBontones.TabIndex = 12;
            // 
            // btCancelar
            // 
            btCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCancelar.BackColor = Color.Red;
            btCancelar.FlatStyle = FlatStyle.Popup;
            btCancelar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelar.Location = new Point(54, 135);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(238, 41);
            btCancelar.TabIndex = 14;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += button2_Click;
            // 
            // btAgregar
            // 
            btAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAgregar.BackColor = Color.Lime;
            btAgregar.FlatStyle = FlatStyle.Popup;
            btAgregar.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btAgregar.Location = new Point(54, 19);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(238, 69);
            btAgregar.TabIndex = 13;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // AgregarAnimalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(782, 553);
            Controls.Add(tlp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AgregarAnimalView";
            Text = "AgregarAnimalView";
            tlp.ResumeLayout(false);
            tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).EndInit();
            pBontones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TableLayoutPanel tlp;
        private Label txtEspecie;
        private ComboBox cbEspecie;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblPais;
        private Label lblPeso;
        private Label lblSectores;
        private Panel pBontones;
        private Button btAgregar;
        private Button btCancelar;
        private BindingSource especieBindingSource;
        private BindingSource paisBindingSource;
        private CheckedListBox clbSectores;
        private TextBox txtPeso;
        private ComboBox cbPais;
    }
}