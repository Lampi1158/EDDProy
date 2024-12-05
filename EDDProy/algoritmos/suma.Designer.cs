namespace EDDemo.algoritmos
{
    partial class suma
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
            this.listresultado = new System.Windows.Forms.ListBox();
            this.buttonsuma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textarreglo1 = new System.Windows.Forms.TextBox();
            this.textarreglo2 = new System.Windows.Forms.TextBox();
            this.labelresultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listresultado
            // 
            this.listresultado.FormattingEnabled = true;
            this.listresultado.ItemHeight = 16;
            this.listresultado.Location = new System.Drawing.Point(26, 80);
            this.listresultado.Name = "listresultado";
            this.listresultado.Size = new System.Drawing.Size(158, 132);
            this.listresultado.TabIndex = 4;
            // 
            // buttonsuma
            // 
            this.buttonsuma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonsuma.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonsuma.Location = new System.Drawing.Point(248, 250);
            this.buttonsuma.Name = "buttonsuma";
            this.buttonsuma.Size = new System.Drawing.Size(133, 45);
            this.buttonsuma.TabIndex = 5;
            this.buttonsuma.Text = "suma";
            this.buttonsuma.UseVisualStyleBackColor = false;
            this.buttonsuma.Click += new System.EventHandler(this.buttonsuma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa los numeros a sumar";
            // 
            // textarreglo1
            // 
            this.textarreglo1.Location = new System.Drawing.Point(263, 100);
            this.textarreglo1.Name = "textarreglo1";
            this.textarreglo1.Size = new System.Drawing.Size(100, 22);
            this.textarreglo1.TabIndex = 7;
            // 
            // textarreglo2
            // 
            this.textarreglo2.Location = new System.Drawing.Point(263, 168);
            this.textarreglo2.Name = "textarreglo2";
            this.textarreglo2.Size = new System.Drawing.Size(100, 22);
            this.textarreglo2.TabIndex = 8;
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.ForeColor = System.Drawing.Color.Black;
            this.labelresultado.Location = new System.Drawing.Point(33, 250);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(97, 16);
            this.labelresultado.TabIndex = 9;
            this.labelresultado.Text = "..............................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(301, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            // 
            // suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.textarreglo2);
            this.Controls.Add(this.textarreglo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsuma);
            this.Controls.Add(this.listresultado);
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Name = "suma";
            this.Text = "suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listresultado;
        private System.Windows.Forms.Button buttonsuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textarreglo1;
        private System.Windows.Forms.TextBox textarreglo2;
        private System.Windows.Forms.Label labelresultado;
        private System.Windows.Forms.Label label2;
    }
}