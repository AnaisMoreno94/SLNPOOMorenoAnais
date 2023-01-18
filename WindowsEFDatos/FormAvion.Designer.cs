namespace WindowsEFDatos
{
    partial class FormAvion
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
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.btnInsertarAvion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(76, 221);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.RowHeadersWidth = 51;
            this.gridAviones.RowTemplate.Height = 24;
            this.gridAviones.Size = new System.Drawing.Size(614, 168);
            this.gridAviones.TabIndex = 0;
            // 
            // btnInsertarAvion
            // 
            this.btnInsertarAvion.Location = new System.Drawing.Point(302, 147);
            this.btnInsertarAvion.Name = "btnInsertarAvion";
            this.btnInsertarAvion.Size = new System.Drawing.Size(135, 42);
            this.btnInsertarAvion.TabIndex = 1;
            this.btnInsertarAvion.Text = "Insertar Avion";
            this.btnInsertarAvion.UseVisualStyleBackColor = true;
            this.btnInsertarAvion.Click += new System.EventHandler(this.btnInsertarAvion_Click);
            // 
            // FormAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertarAvion);
            this.Controls.Add(this.gridAviones);
            this.Name = "FormAvion";
            this.Text = "FormAvion";
            this.Load += new System.EventHandler(this.FormAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.Button btnInsertarAvion;
    }
}