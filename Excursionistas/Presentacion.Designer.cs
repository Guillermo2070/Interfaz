namespace Excursionistas
{
    partial class Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPeso = new System.Windows.Forms.TextBox();
            this.TbCalorias = new System.Windows.Forms.TextBox();
            this.TbRespuesta = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calorias:";
            // 
            // TbPeso
            // 
            this.TbPeso.Location = new System.Drawing.Point(55, 20);
            this.TbPeso.Name = "TbPeso";
            this.TbPeso.Size = new System.Drawing.Size(100, 20);
            this.TbPeso.TabIndex = 2;
            // 
            // TbCalorias
            // 
            this.TbCalorias.Location = new System.Drawing.Point(233, 20);
            this.TbCalorias.Name = "TbCalorias";
            this.TbCalorias.Size = new System.Drawing.Size(100, 20);
            this.TbCalorias.TabIndex = 3;
            // 
            // TbRespuesta
            // 
            this.TbRespuesta.Location = new System.Drawing.Point(15, 46);
            this.TbRespuesta.Multiline = true;
            this.TbRespuesta.Name = "TbRespuesta";
            this.TbRespuesta.Size = new System.Drawing.Size(550, 129);
            this.TbRespuesta.TabIndex = 4;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(490, 18);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 5;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 184);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TbRespuesta);
            this.Controls.Add(this.TbCalorias);
            this.Controls.Add(this.TbPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prsentacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPeso;
        private System.Windows.Forms.TextBox TbCalorias;
        private System.Windows.Forms.TextBox TbRespuesta;
        private System.Windows.Forms.Button BtnVerificar;
    }
}

