namespace TrabajoParcial
{
    partial class FormArrendador
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
            this.dgConductor = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerEspacio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConductor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConductor
            // 
            this.dgConductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConductor.Location = new System.Drawing.Point(23, 72);
            this.dgConductor.Name = "dgConductor";
            this.dgConductor.RowHeadersWidth = 51;
            this.dgConductor.RowTemplate.Height = 24;
            this.dgConductor.Size = new System.Drawing.Size(339, 327);
            this.dgConductor.TabIndex = 55;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(700, 366);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVerEspacio
            // 
            this.btnVerEspacio.Location = new System.Drawing.Point(390, 110);
            this.btnVerEspacio.Name = "btnVerEspacio";
            this.btnVerEspacio.Size = new System.Drawing.Size(105, 33);
            this.btnVerEspacio.TabIndex = 67;
            this.btnVerEspacio.Text = "Ver Espacio";
            this.btnVerEspacio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 68;
            this.button1.Text = "Registrar Espacio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ubicaciones de Reservas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 70;
            this.button2.Text = "Reportes Usuario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerEspacio);
            this.Controls.Add(this.dgConductor);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormArrendador";
            this.Text = "FormArrendador";
            ((System.ComponentModel.ISupportInitialize)(this.dgConductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgConductor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerEspacio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}