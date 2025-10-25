namespace TrabajoParcial
{
    partial class FormEspacioArrendador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidespacioalquilar = new System.Windows.Forms.TextBox();
            this.txttarifaporhora = new System.Windows.Forms.TextBox();
            this.txtubicacionalquilar = new System.Windows.Forms.TextBox();
            this.txtareaalquilar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarifa x hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese los datos de su Espacio a Alquilar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Área:";
            // 
            // txtidespacioalquilar
            // 
            this.txtidespacioalquilar.Location = new System.Drawing.Point(145, 86);
            this.txtidespacioalquilar.Name = "txtidespacioalquilar";
            this.txtidespacioalquilar.Size = new System.Drawing.Size(142, 20);
            this.txtidespacioalquilar.TabIndex = 5;
            // 
            // txttarifaporhora
            // 
            this.txttarifaporhora.Location = new System.Drawing.Point(145, 119);
            this.txttarifaporhora.Name = "txttarifaporhora";
            this.txttarifaporhora.Size = new System.Drawing.Size(142, 20);
            this.txttarifaporhora.TabIndex = 6;
            // 
            // txtubicacionalquilar
            // 
            this.txtubicacionalquilar.Location = new System.Drawing.Point(145, 152);
            this.txtubicacionalquilar.Name = "txtubicacionalquilar";
            this.txtubicacionalquilar.Size = new System.Drawing.Size(142, 20);
            this.txtubicacionalquilar.TabIndex = 7;
            // 
            // txtareaalquilar
            // 
            this.txtareaalquilar.Location = new System.Drawing.Point(145, 182);
            this.txtareaalquilar.Name = "txtareaalquilar";
            this.txtareaalquilar.Size = new System.Drawing.Size(142, 20);
            this.txtareaalquilar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEspacioArrendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtareaalquilar);
            this.Controls.Add(this.txtubicacionalquilar);
            this.Controls.Add(this.txttarifaporhora);
            this.Controls.Add(this.txtidespacioalquilar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEspacioArrendador";
            this.Text = "FormEspacioArrendador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidespacioalquilar;
        private System.Windows.Forms.TextBox txttarifaporhora;
        private System.Windows.Forms.TextBox txtubicacionalquilar;
        private System.Windows.Forms.TextBox txtareaalquilar;
        private System.Windows.Forms.Button button1;
    }
}