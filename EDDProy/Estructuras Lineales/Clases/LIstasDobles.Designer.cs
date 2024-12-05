namespace EDDemo.Estructuras_Lineales.Clases
{
    partial class LIstasDobles
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
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnEliminarFinal = new System.Windows.Forms.Button();
            this.btnAgregarFinal = new System.Windows.Forms.Button();
            this.btnEliminarFinañ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listLista = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicio.Location = new System.Drawing.Point(12, 138);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(230, 52);
            this.btnAgregarInicio.TabIndex = 0;
            this.btnAgregarInicio.Text = "Agregar al inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(314, 58);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(152, 30);
            this.txtDato.TabIndex = 1;
            // 
            // btnEliminarFinal
            // 
            this.btnEliminarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFinal.Location = new System.Drawing.Point(12, 254);
            this.btnEliminarFinal.Name = "btnEliminarFinal";
            this.btnEliminarFinal.Size = new System.Drawing.Size(230, 52);
            this.btnEliminarFinal.TabIndex = 2;
            this.btnEliminarFinal.Text = "Eliminar al inicio";
            this.btnEliminarFinal.UseVisualStyleBackColor = true;
            this.btnEliminarFinal.Click += new System.EventHandler(this.btnEliminarFinal_Click);
            // 
            // btnAgregarFinal
            // 
            this.btnAgregarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFinal.Location = new System.Drawing.Point(12, 196);
            this.btnAgregarFinal.Name = "btnAgregarFinal";
            this.btnAgregarFinal.Size = new System.Drawing.Size(230, 52);
            this.btnAgregarFinal.TabIndex = 3;
            this.btnAgregarFinal.Text = "Agregar al final";
            this.btnAgregarFinal.UseVisualStyleBackColor = true;
            this.btnAgregarFinal.Click += new System.EventHandler(this.btnAgregarFinal_Click);
            // 
            // btnEliminarFinañ
            // 
            this.btnEliminarFinañ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFinañ.Location = new System.Drawing.Point(12, 312);
            this.btnEliminarFinañ.Name = "btnEliminarFinañ";
            this.btnEliminarFinañ.Size = new System.Drawing.Size(230, 52);
            this.btnEliminarFinañ.TabIndex = 4;
            this.btnEliminarFinañ.Text = "Eliminar al final";
            this.btnEliminarFinañ.UseVisualStyleBackColor = true;
            this.btnEliminarFinañ.Click += new System.EventHandler(this.btnEliminarFinañ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "....................";
            // 
            // listLista
            // 
            this.listLista.FormattingEnabled = true;
            this.listLista.ItemHeight = 16;
            this.listLista.Location = new System.Drawing.Point(568, 161);
            this.listLista.Name = "listLista";
            this.listLista.Size = new System.Drawing.Size(230, 244);
            this.listLista.TabIndex = 6;
            this.listLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(568, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(230, 52);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar un nodo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LIstasDobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(928, 519);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarFinañ);
            this.Controls.Add(this.btnAgregarFinal);
            this.Controls.Add(this.btnEliminarFinal);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnAgregarInicio);
            this.Name = "LIstasDobles";
            this.Text = "LIstasDobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnEliminarFinal;
        private System.Windows.Forms.Button btnAgregarFinal;
        private System.Windows.Forms.Button btnEliminarFinañ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.Button btnBuscar;
    }
}