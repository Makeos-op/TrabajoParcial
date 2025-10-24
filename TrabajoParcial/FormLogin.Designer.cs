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
            this.cmbtipousuariologin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARKEA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDO A PARKEA ¡ENCANTADOS DE VERTE!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // txtususario
            // 
            this.txtususario.Location = new System.Drawing.Point(196, 91);
            this.txtususario.Name = "txtususario";
            this.txtususario.Size = new System.Drawing.Size(252, 20);
            this.txtususario.TabIndex = 4;
            // 
            // txtcontrasenalogin
            // 
            this.txtcontrasenalogin.Location = new System.Drawing.Point(196, 134);
            this.txtcontrasenalogin.Name = "txtcontrasenalogin";
            this.txtcontrasenalogin.Size = new System.Drawing.Size(252, 20);
            this.txtcontrasenalogin.TabIndex = 5;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(235, 209);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(104, 23);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(346, 245);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(100, 23);
            this.btnregistrarse.TabIndex = 8;
            this.btnregistrarse.Text = "REGISTRARSE";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "¿No tienes cuenta? Crea una ahora";
            // 
            // cmbtipousuariologin
            // 
            this.cmbtipousuariologin.FormattingEnabled = true;
            this.cmbtipousuariologin.Location = new System.Drawing.Point(276, 173);
            this.cmbtipousuariologin.Name = "cmbtipousuariologin";
            this.cmbtipousuariologin.Size = new System.Drawing.Size(133, 21);
            this.cmbtipousuariologin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TIPO DE USUARIO:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbtipousuariologin);
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
        private System.Windows.Forms.ComboBox cmbtipousuariologin;
        private System.Windows.Forms.Label label6;
    }
}