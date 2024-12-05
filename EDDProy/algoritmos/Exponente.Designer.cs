namespace EDDemo.algoritmos
{
    partial class Exponente
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxArreglo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExponente = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(158, 119);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(235, 16);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "AQUI MOSTRAMOS EL RESULTADO";
            // 
            // textBoxArreglo
            // 
            this.textBoxArreglo.Location = new System.Drawing.Point(442, 113);
            this.textBoxArreglo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArreglo.Name = "textBoxArreglo";
            this.textBoxArreglo.Size = new System.Drawing.Size(132, 22);
            this.textBoxArreglo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coloca los exponentes";
            // 
            // textBoxExponente
            // 
            this.textBoxExponente.Location = new System.Drawing.Point(220, 182);
            this.textBoxExponente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExponente.Name = "textBoxExponente";
            this.textBoxExponente.Size = new System.Drawing.Size(132, 22);
            this.textBoxExponente.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCalcular.Location = new System.Drawing.Point(442, 193);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(100, 60);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Exponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxExponente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArreglo);
            this.Controls.Add(this.labelResultado);
            this.Name = "Exponente";
            this.Text = "Exponente";
            this.Load += new System.EventHandler(this.Exponente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExponente;
        private System.Windows.Forms.Button buttonCalcular;
    }
}