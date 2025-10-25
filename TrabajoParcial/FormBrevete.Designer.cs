namespace TrabajoParcial
{
    partial class FormBrevete
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
            this.btnregistrarbrevete = new System.Windows.Forms.Button();
            this.txtfechacaducidad = new System.Windows.Forms.TextBox();
            this.txtfechaemision = new System.Windows.Forms.TextBox();
            this.txtcategoriabrevete = new System.Windows.Forms.TextBox();
            this.txtidbrevete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregistrarbrevete
            // 
            this.btnregistrarbrevete.Location = new System.Drawing.Point(121, 241);
            this.btnregistrarbrevete.Name = "btnregistrarbrevete";
            this.btnregistrarbrevete.Size = new System.Drawing.Size(75, 23);
            this.btnregistrarbrevete.TabIndex = 19;
            this.btnregistrarbrevete.Text = "Registrar";
            this.btnregistrarbrevete.UseVisualStyleBackColor = true;
            this.btnregistrarbrevete.Click += new System.EventHandler(this.btnregistrarbrevete_Click);
            // 
            // txtfechacaducidad
            // 
            this.txtfechacaducidad.Location = new System.Drawing.Point(163, 201);
            this.txtfechacaducidad.Name = "txtfechacaducidad";
            this.txtfechacaducidad.Size = new System.Drawing.Size(142, 20);
            this.txtfechacaducidad.TabIndex = 18;
            // 
            // txtfechaemision
            // 
            this.txtfechaemision.Location = new System.Drawing.Point(163, 171);
            this.txtfechaemision.Name = "txtfechaemision";
            this.txtfechaemision.Size = new System.Drawing.Size(142, 20);
            this.txtfechaemision.TabIndex = 17;
            // 
            // txtcategoriabrevete
            // 
            this.txtcategoriabrevete.Location = new System.Drawing.Point(163, 138);
            this.txtcategoriabrevete.Name = "txtcategoriabrevete";
            this.txtcategoriabrevete.Size = new System.Drawing.Size(142, 20);
            this.txtcategoriabrevete.TabIndex = 16;
            // 
            // txtidbrevete
            // 
            this.txtidbrevete.Location = new System.Drawing.Point(163, 105);
            this.txtidbrevete.Name = "txtidbrevete";
            this.txtidbrevete.Size = new System.Drawing.Size(142, 20);
            this.txtidbrevete.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de caducidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingrese los datos de su Brevete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de emisión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // FormBrevete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.btnregistrarbrevete);
            this.Controls.Add(this.txtfechacaducidad);
            this.Controls.Add(this.txtfechaemision);
            this.Controls.Add(this.txtcategoriabrevete);
            this.Controls.Add(this.txtidbrevete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBrevete";
            this.Text = "FormBrevete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrarbrevete;
        private System.Windows.Forms.TextBox txtfechacaducidad;
        private System.Windows.Forms.TextBox txtfechaemision;
        private System.Windows.Forms.TextBox txtcategoriabrevete;
        private System.Windows.Forms.TextBox txtidbrevete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}