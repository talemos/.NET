namespace projeto1
{
    partial class frmEscola
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
            this.lblEscola = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(27, 111);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(42, 13);
            this.lblEscola.TabIndex = 0;
            this.lblEscola.Text = "Escola:";
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(30, 85);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(100, 20);
            this.txtEscola.TabIndex = 1;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(145, 85);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 2;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.lblEscola);
            this.Name = "frmEscola";
            this.Text = "Escola";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.Button cmdMostrar;
    }
}