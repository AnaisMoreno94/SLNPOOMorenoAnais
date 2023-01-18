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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDeno = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraerUno = new System.Windows.Forms.Button();
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
            this.btnInsertarAvion.Location = new System.Drawing.Point(76, 157);
            this.btnInsertarAvion.Name = "btnInsertarAvion";
            this.btnInsertarAvion.Size = new System.Drawing.Size(135, 42);
            this.btnInsertarAvion.TabIndex = 1;
            this.btnInsertarAvion.Text = "Insertar Avion";
            this.btnInsertarAvion.UseVisualStyleBackColor = true;
            this.btnInsertarAvion.Click += new System.EventHandler(this.btnInsertarAvion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Avion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Denominacion";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtDeno
            // 
            this.txtDeno.Location = new System.Drawing.Point(173, 93);
            this.txtDeno.Name = "txtDeno";
            this.txtDeno.Size = new System.Drawing.Size(144, 22);
            this.txtDeno.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(234, 157);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar Avion";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(392, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Avion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraerUno
            // 
            this.btnTraerUno.Location = new System.Drawing.Point(555, 157);
            this.btnTraerUno.Name = "btnTraerUno";
            this.btnTraerUno.Size = new System.Drawing.Size(135, 42);
            this.btnTraerUno.TabIndex = 8;
            this.btnTraerUno.Text = "Buscar Avion (ID)";
            this.btnTraerUno.UseVisualStyleBackColor = true;
            this.btnTraerUno.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerUno);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtDeno);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarAvion);
            this.Controls.Add(this.gridAviones);
            this.Name = "FormAvion";
            this.Text = "FormAvion";
            this.Load += new System.EventHandler(this.FormAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.Button btnInsertarAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDeno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraerUno;
    }
}