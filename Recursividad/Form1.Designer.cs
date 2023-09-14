namespace Recursividad
{
    partial class Form1
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
            this.Factorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.lbFactorial = new System.Windows.Forms.Label();
            this.tbFactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fibonacci = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalcularFibonacci = new System.Windows.Forms.Button();
            this.lbFibonacci = new System.Windows.Forms.Label();
            this.tbFibonacci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalcularMcd = new System.Windows.Forms.Button();
            this.lbMcd = new System.Windows.Forms.Label();
            this.tbMcd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMcd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mcd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(31, 37);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(126, 36);
            this.Factorial.TabIndex = 0;
            this.Factorial.Text = "Factorial";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcularFactorial);
            this.panel1.Controls.Add(this.lbFactorial);
            this.panel1.Controls.Add(this.tbFactorial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 262);
            this.panel1.TabIndex = 1;
            // 
            // btnCalcularFactorial
            // 
            this.btnCalcularFactorial.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcularFactorial.Location = new System.Drawing.Point(23, 169);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(97, 24);
            this.btnCalcularFactorial.TabIndex = 3;
            this.btnCalcularFactorial.Text = "Calcular";
            this.btnCalcularFactorial.UseVisualStyleBackColor = false;
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);
            // 
            // lbFactorial
            // 
            this.lbFactorial.AutoSize = true;
            this.lbFactorial.Location = new System.Drawing.Point(41, 100);
            this.lbFactorial.Name = "lbFactorial";
            this.lbFactorial.Size = new System.Drawing.Size(0, 16);
            this.lbFactorial.TabIndex = 2;
            // 
            // tbFactorial
            // 
            this.tbFactorial.Location = new System.Drawing.Point(23, 49);
            this.tbFactorial.Name = "tbFactorial";
            this.tbFactorial.Size = new System.Drawing.Size(93, 22);
            this.tbFactorial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe el numero:";
            // 
            // Fibonacci
            // 
            this.Fibonacci.Location = new System.Drawing.Point(262, 37);
            this.Fibonacci.Name = "Fibonacci";
            this.Fibonacci.Size = new System.Drawing.Size(128, 36);
            this.Fibonacci.TabIndex = 2;
            this.Fibonacci.Text = "Fibonacci";
            this.Fibonacci.UseVisualStyleBackColor = true;
            this.Fibonacci.Click += new System.EventHandler(this.Fibonacci_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCalcularFibonacci);
            this.panel2.Controls.Add(this.lbFibonacci);
            this.panel2.Controls.Add(this.tbFibonacci);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(234, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 262);
            this.panel2.TabIndex = 3;
            // 
            // btnCalcularFibonacci
            // 
            this.btnCalcularFibonacci.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcularFibonacci.Location = new System.Drawing.Point(28, 164);
            this.btnCalcularFibonacci.Name = "btnCalcularFibonacci";
            this.btnCalcularFibonacci.Size = new System.Drawing.Size(105, 29);
            this.btnCalcularFibonacci.TabIndex = 3;
            this.btnCalcularFibonacci.Text = "Calcular";
            this.btnCalcularFibonacci.UseVisualStyleBackColor = false;
            this.btnCalcularFibonacci.Click += new System.EventHandler(this.btnCalcularFibonacci_Click);
            // 
            // lbFibonacci
            // 
            this.lbFibonacci.AutoSize = true;
            this.lbFibonacci.Location = new System.Drawing.Point(55, 100);
            this.lbFibonacci.Name = "lbFibonacci";
            this.lbFibonacci.Size = new System.Drawing.Size(0, 16);
            this.lbFibonacci.TabIndex = 2;
            // 
            // tbFibonacci
            // 
            this.tbFibonacci.Location = new System.Drawing.Point(17, 49);
            this.tbFibonacci.Name = "tbFibonacci";
            this.tbFibonacci.Size = new System.Drawing.Size(116, 22);
            this.tbFibonacci.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Escribe el numero:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCalcularMcd);
            this.panel3.Controls.Add(this.lbMcd);
            this.panel3.Controls.Add(this.tbMcd2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbMcd1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(479, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 261);
            this.panel3.TabIndex = 4;
            // 
            // btnCalcularMcd
            // 
            this.btnCalcularMcd.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcularMcd.Location = new System.Drawing.Point(49, 176);
            this.btnCalcularMcd.Name = "btnCalcularMcd";
            this.btnCalcularMcd.Size = new System.Drawing.Size(108, 27);
            this.btnCalcularMcd.TabIndex = 5;
            this.btnCalcularMcd.Text = "Calcular";
            this.btnCalcularMcd.UseVisualStyleBackColor = false;
            this.btnCalcularMcd.Click += new System.EventHandler(this.btnCalcularMcd_Click);
            // 
            // lbMcd
            // 
            this.lbMcd.AutoSize = true;
            this.lbMcd.Location = new System.Drawing.Point(96, 135);
            this.lbMcd.Name = "lbMcd";
            this.lbMcd.Size = new System.Drawing.Size(0, 16);
            this.lbMcd.TabIndex = 4;
            // 
            // tbMcd2
            // 
            this.tbMcd2.Location = new System.Drawing.Point(135, 77);
            this.tbMcd2.Name = "tbMcd2";
            this.tbMcd2.Size = new System.Drawing.Size(86, 22);
            this.tbMcd2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero2:";
            // 
            // tbMcd1
            // 
            this.tbMcd1.Location = new System.Drawing.Point(23, 76);
            this.tbMcd1.Name = "tbMcd1";
            this.tbMcd1.Size = new System.Drawing.Size(77, 22);
            this.tbMcd1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero1:";
            // 
            // Mcd
            // 
            this.Mcd.Location = new System.Drawing.Point(538, 36);
            this.Mcd.Name = "Mcd";
            this.Mcd.Size = new System.Drawing.Size(124, 37);
            this.Mcd.TabIndex = 5;
            this.Mcd.Text = "MCD";
            this.Mcd.UseVisualStyleBackColor = true;
            this.Mcd.Click += new System.EventHandler(this.Mcd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mcd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Fibonacci);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Factorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Label lbFactorial;
        private System.Windows.Forms.TextBox tbFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fibonacci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcularFibonacci;
        private System.Windows.Forms.Label lbFibonacci;
        private System.Windows.Forms.TextBox tbFibonacci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalcularMcd;
        private System.Windows.Forms.Label lbMcd;
        private System.Windows.Forms.TextBox tbMcd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMcd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Mcd;
    }
}

