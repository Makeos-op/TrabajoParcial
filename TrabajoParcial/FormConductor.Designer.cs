namespace TrabajoParcial
{
    partial class FormConductor
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(108, -20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(117, 22);
            this.tbId.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id";
            // 
            // FormConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 407);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConductor";
            this.Text = "FormConductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
    }
}