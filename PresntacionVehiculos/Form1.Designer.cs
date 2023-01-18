namespace PresntacionVehiculos
{
    partial class btnCrearCamionRemolque
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
            this.btnCrearCamion = new System.Windows.Forms.Button();
            this.btnCrearRemolque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCamion
            // 
            this.btnCrearCamion.Location = new System.Drawing.Point(51, 32);
            this.btnCrearCamion.Name = "btnCrearCamion";
            this.btnCrearCamion.Size = new System.Drawing.Size(146, 56);
            this.btnCrearCamion.TabIndex = 0;
            this.btnCrearCamion.Text = "Crear Camion";
            this.btnCrearCamion.UseVisualStyleBackColor = true;
            this.btnCrearCamion.Click += new System.EventHandler(this.btnCrearCamion_Click);
            // 
            // btnCrearRemolque
            // 
            this.btnCrearRemolque.Location = new System.Drawing.Point(51, 133);
            this.btnCrearRemolque.Name = "btnCrearRemolque";
            this.btnCrearRemolque.Size = new System.Drawing.Size(146, 63);
            this.btnCrearRemolque.TabIndex = 1;
            this.btnCrearRemolque.Text = "Crear Remolque";
            this.btnCrearRemolque.UseVisualStyleBackColor = true;
            this.btnCrearRemolque.Click += new System.EventHandler(this.btnCrearRemolque_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Camion con Remolque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearCamionRemolque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearRemolque);
            this.Controls.Add(this.btnCrearCamion);
            this.Name = "btnCrearCamionRemolque";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCamion;
        private System.Windows.Forms.Button btnCrearRemolque;
        private System.Windows.Forms.Button button1;
    }
}

