namespace projeto1
{
    partial class frmCurso
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
            this.cmdCurso = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCurso
            // 
            this.cmdCurso.Location = new System.Drawing.Point(91, 85);
            this.cmdCurso.Name = "cmdCurso";
            this.cmdCurso.Size = new System.Drawing.Size(75, 23);
            this.cmdCurso.TabIndex = 0;
            this.cmdCurso.Text = "Curso";
            this.cmdCurso.UseVisualStyleBackColor = true;
            this.cmdCurso.Click += new System.EventHandler(this.cmdCurso_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(88, 124);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cmdCurso);
            this.Name = "frmCurso";
            this.Text = "Mostrar Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCurso;
        private System.Windows.Forms.Label lblCurso;
    }
}

