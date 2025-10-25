namespace TrabajoParcial
{
    partial class FormLogin
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
            this.txtususario = new System.Windows.Forms.TextBox();
            this.txtcontrasenalogin = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(304, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARKEA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDO A PARKEA ¡ENCANTADOS DE VERTE!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // txtususario
            // 
            this.txtususario.Location = new System.Drawing.Point(261, 112);
            this.txtususario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtususario.Name = "txtususario";
            this.txtususario.Size = new System.Drawing.Size(335, 22);
            this.txtususario.TabIndex = 4;
            // 
            // txtcontrasenalogin
            // 
            this.txtcontrasenalogin.Location = new System.Drawing.Point(261, 165);
            this.txtcontrasenalogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontrasenalogin.Name = "txtcontrasenalogin";
            this.txtcontrasenalogin.Size = new System.Drawing.Size(335, 22);
            this.txtcontrasenalogin.TabIndex = 5;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(304, 218);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(139, 28);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 323);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(404, 272);
            this.btnregistrarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(133, 28);
            this.btnregistrarse.TabIndex = 8;
            this.btnregistrarse.Text = "REGISTRARSE";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "¿No tienes cuenta? Crea una ahora";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnregistrarse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasenalogin);
            this.Controls.Add(this.txtususario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtususario;
        private System.Windows.Forms.TextBox txtcontrasenalogin;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnregistrarse;
        private System.Windows.Forms.Label label5;
    }
}