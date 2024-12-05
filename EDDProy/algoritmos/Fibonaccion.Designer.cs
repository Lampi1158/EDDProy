namespace EDDemo.algoritmos
{
    partial class Fibonaccion
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArreglo = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(130, 103);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(159, 116);
            this.listBoxResultado.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(319, 357);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(184, 16);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Aquí se mostrará el resultado.";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESAR EL NUMERO";
            // 
            // textBoxArreglo
            // 
            this.textBoxArreglo.Location = new System.Drawing.Point(323, 184);
            this.textBoxArreglo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArreglo.Name = "textBoxArreglo";
            this.textBoxArreglo.Size = new System.Drawing.Size(180, 22);
            this.textBoxArreglo.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCalcular.Location = new System.Drawing.Point(323, 234);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(164, 57);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular Fibonacci";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Fibonaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxArreglo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "Fibonaccion";
            this.Text = "Fibonaccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArreglo;
        private System.Windows.Forms.Button buttonCalcular;
    }
}