﻿namespace TrabajoParcial
{
    partial class FormEspacio
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
            this.dgEspacio = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbTarifaxHora = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEspacio
            // 
            this.dgEspacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspacio.Location = new System.Drawing.Point(12, 212);
            this.dgEspacio.Name = "dgEspacio";
            this.dgEspacio.RowHeadersWidth = 51;
            this.dgEspacio.RowTemplate.Height = 24;
            this.dgEspacio.Size = new System.Drawing.Size(776, 226);
            this.dgEspacio.TabIndex = 23;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(123, 164);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 164);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 33);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(108, 114);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(117, 22);
            this.tbArea.TabIndex = 19;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(108, 77);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(117, 22);
            this.tbUbicacion.TabIndex = 18;
            // 
            // tbTarifaxHora
            // 
            this.tbTarifaxHora.Location = new System.Drawing.Point(108, 49);
            this.tbTarifaxHora.Name = "tbTarifaxHora";
            this.tbTarifaxHora.Size = new System.Drawing.Size(117, 22);
            this.tbTarifaxHora.TabIndex = 17;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(108, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(117, 22);
            this.tbId.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ubicacion";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(18, 52);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(84, 16);
            this.Modelo.TabIndex = 13;
            this.Modelo.Text = "Tarifa x Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // FormEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgEspacio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.tbTarifaxHora);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.label1);
            this.Name = "FormEspacio";
            this.Text = "FormEspacio";
            this.Load += new System.EventHandler(this.FormEspacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEspacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEspacio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbTarifaxHora;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label label1;
    }
}