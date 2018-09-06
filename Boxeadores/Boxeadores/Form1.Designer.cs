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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad_individuos = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.Enabled = false;
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
            this.Evolucionar.Enabled = false;
            this.Evolucionar.Location = new System.Drawing.Point(179, 12);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verificar);
            this.groupBox1.Controls.Add(this.cantidad_individuos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(442, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos configuración AE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Individuos:";
            // 
            // cantidad_individuos
            // 
            this.cantidad_individuos.Location = new System.Drawing.Point(19, 42);
            this.cantidad_individuos.Name = "cantidad_individuos";
            this.cantidad_individuos.Size = new System.Drawing.Size(201, 20);
            this.cantidad_individuos.TabIndex = 1;
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(0, 166);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(236, 26);
            this.verificar.TabIndex = 2;
            this.verificar.Text = "Verificar configuración";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.poblacion);
            this.Controls.Add(this.Evolucionar);
            this.Controls.Add(this.Generar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Button Evolucionar;
        private System.Windows.Forms.ListBox poblacion;
        private System.Windows.Forms.ListBox resultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.TextBox cantidad_individuos;
        private System.Windows.Forms.Label label1;
    }
}

