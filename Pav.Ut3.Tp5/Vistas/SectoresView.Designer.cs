namespace Pav.Ut3.Tp5.Vistas
{
    partial class SectoresView
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
            lbelValorCarnivoro = new Label();
            pnlBotones = new Panel();
            btnAnimal = new Button();
            lblKgsHerbivoro = new Label();
            lblKgsCarnivoro = new Label();
            lbelValorTotal = new Label();
            lbelValorHerbivoro = new Label();
            lblKgsTotal = new Label();
            tlpLabels = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblValorCarne = new Label();
            btnCalcular = new Button();
            flpSectores = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlBotones.SuspendLayout();
            tlpLabels.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbelValorCarnivoro
            // 
            lbelValorCarnivoro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbelValorCarnivoro.BackColor = SystemColors.ActiveCaptionText;
            lbelValorCarnivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorCarnivoro.Location = new Point(3, 0);
            lbelValorCarnivoro.Name = "lbelValorCarnivoro";
            lbelValorCarnivoro.Size = new Size(479, 5);
            lbelValorCarnivoro.TabIndex = 3;
            lbelValorCarnivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotones
            // 
            pnlBotones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBotones.BackColor = SystemColors.Info;
            pnlBotones.Controls.Add(btnCalcular);
            pnlBotones.Controls.Add(btnAnimal);
            pnlBotones.Location = new Point(1039, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(482, 252);
            pnlBotones.TabIndex = 1;
            // 
            // btnAnimal
            // 
            btnAnimal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAnimal.BackColor = Color.FromArgb(255, 128, 0);
            btnAnimal.FlatStyle = FlatStyle.Popup;
            btnAnimal.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnimal.Location = new Point(76, 52);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new Size(343, 68);
            btnAnimal.TabIndex = 8;
            btnAnimal.Text = "Agregar Animal";
            btnAnimal.UseVisualStyleBackColor = false;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // lblKgsHerbivoro
            // 
            lblKgsHerbivoro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKgsHerbivoro.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsHerbivoro.Location = new Point(3, 168);
            lblKgsHerbivoro.Name = "lblKgsHerbivoro";
            lblKgsHerbivoro.Size = new Size(479, 79);
            lblKgsHerbivoro.TabIndex = 4;
            lblKgsHerbivoro.Text = "Kgs Herbivoro";
            lblKgsHerbivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgsCarnivoro
            // 
            lblKgsCarnivoro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKgsCarnivoro.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsCarnivoro.Location = new Point(3, 5);
            lblKgsCarnivoro.Name = "lblKgsCarnivoro";
            lblKgsCarnivoro.Size = new Size(479, 79);
            lblKgsCarnivoro.TabIndex = 2;
            lblKgsCarnivoro.Text = "Kgs Carnivoro";
            lblKgsCarnivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbelValorTotal
            // 
            lbelValorTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbelValorTotal.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorTotal.Location = new Point(3, 410);
            lbelValorTotal.Name = "lbelValorTotal";
            lbelValorTotal.Size = new Size(479, 79);
            lbelValorTotal.TabIndex = 7;
            lbelValorTotal.Text = "0";
            lbelValorTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbelValorHerbivoro
            // 
            lbelValorHerbivoro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbelValorHerbivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorHerbivoro.Location = new Point(3, 247);
            lbelValorHerbivoro.Name = "lbelValorHerbivoro";
            lbelValorHerbivoro.Size = new Size(479, 79);
            lbelValorHerbivoro.TabIndex = 5;
            lbelValorHerbivoro.Text = "0";
            lbelValorHerbivoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKgsTotal
            // 
            lblKgsTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKgsTotal.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsTotal.Location = new Point(3, 331);
            lblKgsTotal.Name = "lblKgsTotal";
            lblKgsTotal.Size = new Size(479, 79);
            lblKgsTotal.TabIndex = 6;
            lblKgsTotal.Text = "Kgs Total";
            lblKgsTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpLabels
            // 
            tlpLabels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpLabels.ColumnCount = 1;
            tlpLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLabels.Controls.Add(lbelValorTotal, 0, 8);
            tlpLabels.Controls.Add(lblKgsCarnivoro, 0, 1);
            tlpLabels.Controls.Add(lbelValorCarnivoro, 0, 0);
            tlpLabels.Controls.Add(label1, 0, 9);
            tlpLabels.Controls.Add(lblKgsTotal, 0, 7);
            tlpLabels.Controls.Add(lblKgsHerbivoro, 0, 4);
            tlpLabels.Controls.Add(lbelValorHerbivoro, 0, 5);
            tlpLabels.Controls.Add(label2, 0, 3);
            tlpLabels.Controls.Add(label3, 0, 6);
            tlpLabels.Controls.Add(lblValorCarne, 0, 2);
            tlpLabels.ForeColor = Color.DarkBlue;
            tlpLabels.Location = new Point(1039, 258);
            tlpLabels.Name = "tlpLabels";
            tlpLabels.RowCount = 10;
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666756F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            tlpLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpLabels.Size = new Size(485, 497);
            tlpLabels.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 489);
            label1.Name = "label1";
            label1.Size = new Size(479, 8);
            label1.TabIndex = 8;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 163);
            label2.Name = "label2";
            label2.Size = new Size(479, 5);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 326);
            label3.Name = "label3";
            label3.Size = new Size(479, 5);
            label3.TabIndex = 10;
            // 
            // lblValorCarne
            // 
            lblValorCarne.AutoSize = true;
            lblValorCarne.Dock = DockStyle.Fill;
            lblValorCarne.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblValorCarne.Location = new Point(3, 84);
            lblValorCarne.Name = "lblValorCarne";
            lblValorCarne.Size = new Size(479, 79);
            lblValorCarne.TabIndex = 11;
            lblValorCarne.Text = "0";
            lblValorCarne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.FlatStyle = FlatStyle.Popup;
            btnCalcular.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(76, 165);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(343, 72);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular Comida";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // flpSectores
            // 
            flpSectores.AutoSize = true;
            flpSectores.Location = new Point(3, 3);
            flpSectores.Name = "flpSectores";
            tableLayoutPanel1.SetRowSpan(flpSectores, 2);
            flpSectores.Size = new Size(0, 0);
            flpSectores.TabIndex = 0;
            flpSectores.Paint += flpSectores_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flpSectores, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.77761F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1038, 777);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SectoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1521, 777);
            Controls.Add(tlpLabels);
            Controls.Add(pnlBotones);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SectoresView";
            Text = "SectoresView";
            Load += SectoresView_Load_1;
            pnlBotones.ResumeLayout(false);
            tlpLabels.ResumeLayout(false);
            tlpLabels.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbelValorHerbivoro;
        private Label lblHerbivoroKgs;
        private Label lblValorCarne;
        private Label lblCarnivoroKgs;
        private Button btnComida;
        private Button btnAgregar;
        private Label lbelValorTotal;
        private Label lblKgsTotal;
        private Label lblKgsHerbivoro;
        private Label lbelValorCarnivoro;
        private Label lblKgsCarnivoro;
        private Label lblValorTotal;
        private Label lblTotalKgs;
        private Panel pnlBotones;
        private Button btnAnimal;
        private TableLayoutPanel tlpLabels;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private FlowLayoutPanel flpSectores;
        private TableLayoutPanel tableLayoutPanel1;
    }
}