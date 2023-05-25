namespace Bubble
{
    partial class Burbuja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnOrdenar = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(304, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 31);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(447, 80);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(120, 32);
            btnOrdenar.TabIndex = 1;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(139, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(149, 23);
            txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(262, 30);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 3;
            label1.Text = "Metodo Ordenamiento Burbuja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Insertar Numero";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(25, 168);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(754, 273);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(746, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ver Simulación";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Paint += tabPage1_Paint;
            // 
            // Burbuja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnOrdenar);
            Controls.Add(btnAgregar);
            Name = "Burbuja";
            Text = "Metodo Ordenamiento Bubble";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnOrdenar;
        private TextBox txtNumero;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}