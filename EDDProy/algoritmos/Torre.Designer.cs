namespace EDDemo.algoritmos
{
    partial class Torre
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
            this.listBoxMovimiento = new System.Windows.Forms.ListBox();
            this.textBoxNumeroDiscos = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonResolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMovimiento
            // 
            this.listBoxMovimiento.FormattingEnabled = true;
            this.listBoxMovimiento.ItemHeight = 16;
            this.listBoxMovimiento.Location = new System.Drawing.Point(25, 95);
            this.listBoxMovimiento.Name = "listBoxMovimiento";
            this.listBoxMovimiento.Size = new System.Drawing.Size(213, 132);
            this.listBoxMovimiento.TabIndex = 4;
            // 
            // textBoxNumeroDiscos
            // 
            this.textBoxNumeroDiscos.Location = new System.Drawing.Point(374, 95);
            this.textBoxNumeroDiscos.Name = "textBoxNumeroDiscos";
            this.textBoxNumeroDiscos.Size = new System.Drawing.Size(174, 22);
            this.textBoxNumeroDiscos.TabIndex = 5;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(371, 49);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(181, 16);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Aquí se mostrará el resultado";
            // 
            // buttonResolver
            // 
            this.buttonResolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonResolver.Location = new System.Drawing.Point(399, 180);
            this.buttonResolver.Name = "buttonResolver";
            this.buttonResolver.Size = new System.Drawing.Size(149, 66);
            this.buttonResolver.TabIndex = 7;
            this.buttonResolver.Text = "Resolver";
            this.buttonResolver.UseVisualStyleBackColor = false;
            this.buttonResolver.Click += new System.EventHandler(this.buttonResolver_Click);
            // 
            // Torre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResolver);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxNumeroDiscos);
            this.Controls.Add(this.listBoxMovimiento);
            this.Name = "Torre";
            this.Text = "Torre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMovimiento;
        private System.Windows.Forms.TextBox textBoxNumeroDiscos;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonResolver;
    }
}