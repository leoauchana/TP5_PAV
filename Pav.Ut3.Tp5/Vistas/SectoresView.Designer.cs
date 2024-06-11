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
            flpSectores = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlBotones = new Panel();
            btnCalcular = new Button();
            btnAnimal = new Button();
            lbelValorTotal = new Label();
            lblKgsTotal = new Label();
            lbelValorHerbivoro = new Label();
            lblKgsHerbivoro = new Label();
            lbelValorCarnivoro = new Label();
            lblKgsCarnivoro = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // flpSectores
            // 
            flpSectores.Dock = DockStyle.Fill;
            flpSectores.Location = new Point(3, 3);
            flpSectores.Name = "flpSectores";
            tableLayoutPanel1.SetRowSpan(flpSectores, 2);
            flpSectores.Size = new Size(890, 587);
            flpSectores.TabIndex = 0;
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
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(896, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCalcular);
            pnlBotones.Controls.Add(btnAnimal);
            pnlBotones.Controls.Add(lbelValorTotal);
            pnlBotones.Controls.Add(lblKgsTotal);
            pnlBotones.Controls.Add(lbelValorHerbivoro);
            pnlBotones.Controls.Add(lblKgsHerbivoro);
            pnlBotones.Controls.Add(lbelValorCarnivoro);
            pnlBotones.Controls.Add(lblKgsCarnivoro);
            pnlBotones.Dock = DockStyle.Fill;
            pnlBotones.Location = new Point(896, 0);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(346, 593);
            pnlBotones.TabIndex = 1;
            pnlBotones.Paint += pnlBotones_Paint;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(101, 143);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 29);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular Comida";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAnimal
            // 
            btnAnimal.Location = new Point(98, 69);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new Size(134, 29);
            btnAnimal.TabIndex = 8;
            btnAnimal.Text = "Agregar Animal";
            btnAnimal.UseVisualStyleBackColor = true;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // lbelValorTotal
            // 
            lbelValorTotal.AutoSize = true;
            lbelValorTotal.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorTotal.Location = new Point(154, 439);
            lbelValorTotal.Name = "lbelValorTotal";
            lbelValorTotal.Size = new Size(28, 31);
            lbelValorTotal.TabIndex = 7;
            lbelValorTotal.Text = "0";
            // 
            // lblKgsTotal
            // 
            lblKgsTotal.AutoSize = true;
            lblKgsTotal.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsTotal.Location = new Point(101, 408);
            lblKgsTotal.Name = "lblKgsTotal";
            lblKgsTotal.Size = new Size(121, 31);
            lblKgsTotal.TabIndex = 6;
            lblKgsTotal.Text = "Kgs Total";
            // 
            // lbelValorHerbivoro
            // 
            lbelValorHerbivoro.AutoSize = true;
            lbelValorHerbivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorHerbivoro.Location = new Point(154, 365);
            lbelValorHerbivoro.Name = "lbelValorHerbivoro";
            lbelValorHerbivoro.Size = new Size(28, 31);
            lbelValorHerbivoro.TabIndex = 5;
            lbelValorHerbivoro.Text = "0";
            // 
            // lblKgsHerbivoro
            // 
            lblKgsHerbivoro.AutoSize = true;
            lblKgsHerbivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsHerbivoro.Location = new Point(76, 334);
            lblKgsHerbivoro.Name = "lblKgsHerbivoro";
            lblKgsHerbivoro.Size = new Size(175, 31);
            lblKgsHerbivoro.TabIndex = 4;
            lblKgsHerbivoro.Text = "Kgs Herbivoro";
            // 
            // lbelValorCarnivoro
            // 
            lbelValorCarnivoro.AutoSize = true;
            lbelValorCarnivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbelValorCarnivoro.Location = new Point(154, 292);
            lbelValorCarnivoro.Name = "lbelValorCarnivoro";
            lbelValorCarnivoro.Size = new Size(28, 31);
            lbelValorCarnivoro.TabIndex = 3;
            lbelValorCarnivoro.Text = "0";
            // 
            // lblKgsCarnivoro
            // 
            lblKgsCarnivoro.AutoSize = true;
            lblKgsCarnivoro.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKgsCarnivoro.Location = new Point(76, 261);
            lblKgsCarnivoro.Name = "lblKgsCarnivoro";
            lblKgsCarnivoro.Size = new Size(173, 31);
            lblKgsCarnivoro.TabIndex = 2;
            lblKgsCarnivoro.Text = "Kgs Carnivoro";
            // 
            // SectoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1242, 593);
            Controls.Add(pnlBotones);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SectoresView";
            Text = "SectoresView";
            tableLayoutPanel1.ResumeLayout(false);
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpSectores;
        private Panel panel1;
        private Label lbelValorHerbivoro;
        private Label lblHerbivoroKgs;
        private Label lblValorCarnivoro;
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
        private Button btnCalcular;
        private Button btnAnimal;
    }
}