namespace TrabajoParcial
{
    partial class FormVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerLicencia = new System.Windows.Forms.Button();
            this.dgVehiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(26, 55);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(53, 16);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(108, 12);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(117, 22);
            this.tbMatricula.TabIndex = 4;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(108, 49);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(117, 22);
            this.tbModelo.TabIndex = 5;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(108, 114);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(117, 22);
            this.tbColor.TabIndex = 7;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(108, 77);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(117, 22);
            this.tbMarca.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 164);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 33);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(239, 164);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerLicencia
            // 
            this.btnVerLicencia.Location = new System.Drawing.Point(108, 164);
            this.btnVerLicencia.Name = "btnVerLicencia";
            this.btnVerLicencia.Size = new System.Drawing.Size(104, 33);
            this.btnVerLicencia.TabIndex = 10;
            this.btnVerLicencia.Text = "Ver Licencia";
            this.btnVerLicencia.UseVisualStyleBackColor = true;
            this.btnVerLicencia.Click += new System.EventHandler(this.btnVerLicencia_Click);
            // 
            // dgVehiculo
            // 
            this.dgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculo.Location = new System.Drawing.Point(12, 212);
            this.dgVehiculo.Name = "dgVehiculo";
            this.dgVehiculo.RowHeadersWidth = 51;
            this.dgVehiculo.RowTemplate.Height = 24;
            this.dgVehiculo.Size = new System.Drawing.Size(776, 226);
            this.dgVehiculo.TabIndex = 11;
            this.dgVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehiculo_CellContentClick);
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVehiculo);
            this.Controls.Add(this.btnVerLicencia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.label1);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerLicencia;
        private System.Windows.Forms.DataGridView dgVehiculo;
    }
}