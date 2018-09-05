namespace Boxeadores
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
            this.Generar = new System.Windows.Forms.Button();
            this.Evolucionar = new System.Windows.Forms.Button();
            this.poblacion = new System.Windows.Forms.ListBox();
            this.resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(12, 12);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(148, 23);
            this.Generar.TabIndex = 0;
            this.Generar.Text = "Generar Población";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Evolucionar
            // 
            this.Evolucionar.Location = new System.Drawing.Point(177, 12);
            this.Evolucionar.Name = "Evolucionar";
            this.Evolucionar.Size = new System.Drawing.Size(170, 23);
            this.Evolucionar.TabIndex = 1;
            this.Evolucionar.Text = "Evolucionar Población";
            this.Evolucionar.UseVisualStyleBackColor = true;
            // 
            // poblacion
            // 
            this.poblacion.FormattingEnabled = true;
            this.poblacion.Location = new System.Drawing.Point(12, 59);
            this.poblacion.Name = "poblacion";
            this.poblacion.Size = new System.Drawing.Size(203, 147);
            this.poblacion.TabIndex = 2;
            // 
            // resultados
            // 
            this.resultados.FormattingEnabled = true;
            this.resultados.Location = new System.Drawing.Point(234, 59);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(189, 147);
            this.resultados.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 255);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.poblacion);
            this.Controls.Add(this.Evolucionar);
            this.Controls.Add(this.Generar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Button Evolucionar;
        private System.Windows.Forms.ListBox poblacion;
        private System.Windows.Forms.ListBox resultados;
    }
}

