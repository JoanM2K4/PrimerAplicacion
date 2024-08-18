namespace PrimerAplicacion
{
    partial class Form1
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
            lblTitulo = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblResultado = new Label();
            textNum1 = new TextBox();
            textNum2 = new TextBox();
            btnCalcular = new Button();
            textResultado = new TextBox();
            btnSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            rbDivision = new RadioButton();
            rbMultiplicacion = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(343, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenidos a C#";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(109, 95);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(78, 20);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(109, 152);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(78, 20);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Numero 2:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(109, 208);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // textNum1
            // 
            textNum1.Location = new Point(229, 97);
            textNum1.Name = "textNum1";
            textNum1.PlaceholderText = "Ingrese un numero";
            textNum1.Size = new Size(125, 27);
            textNum1.TabIndex = 4;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(229, 152);
            textNum2.Name = "textNum2";
            textNum2.PlaceholderText = "Ingrese un numero";
            textNum2.Size = new Size(125, 27);
            textNum2.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(594, 409);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // textResultado
            // 
            textResultado.Enabled = false;
            textResultado.Location = new Point(229, 208);
            textResultado.Name = "textResultado";
            textResultado.PlaceholderText = "espere a calcular";
            textResultado.Size = new Size(125, 27);
            textResultado.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(694, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rbDivision);
            panel1.Controls.Add(rbMultiplicacion);
            panel1.Controls.Add(rbResta);
            panel1.Controls.Add(rbSuma);
            panel1.Location = new Point(383, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 189);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 7);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 4;
            label1.Text = "Seleccione la operacion";
            // 
            // rbDivision
            // 
            rbDivision.AutoSize = true;
            rbDivision.Location = new Point(16, 122);
            rbDivision.Name = "rbDivision";
            rbDivision.Size = new Size(83, 24);
            rbDivision.TabIndex = 3;
            rbDivision.Text = "Division";
            rbDivision.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacion
            // 
            rbMultiplicacion.AutoSize = true;
            rbMultiplicacion.Location = new Point(16, 92);
            rbMultiplicacion.Name = "rbMultiplicacion";
            rbMultiplicacion.Size = new Size(124, 24);
            rbMultiplicacion.TabIndex = 2;
            rbMultiplicacion.Text = "Multiplicacion";
            rbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(16, 62);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(66, 24);
            rbResta.TabIndex = 1;
            rbResta.Text = "Resta";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Location = new Point(16, 32);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(67, 24);
            rbSuma.TabIndex = 0;
            rbSuma.Text = "Suma";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(textResultado);
            Controls.Add(btnCalcular);
            Controls.Add(textNum2);
            Controls.Add(textNum1);
            Controls.Add(lblResultado);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "MiPrimeraAplicacion";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblResultado;
        private TextBox textNum1;
        private TextBox textNum2;
        private Button btnCalcular;
        private TextBox textResultado;
        private Button btnSalir;
        private Panel panel1;
        private RadioButton rbMultiplicacion;
        private RadioButton rbResta;
        private RadioButton rbSuma;
        private RadioButton rbDivision;
        private Label label1;
    }
}
