namespace projeto1
{
    partial class frmCursoAndamento
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.lblCursoMostrar = new System.Windows.Forms.Label();
            this.lblSiteMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(37, 26);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(40, 42);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(40, 78);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(28, 13);
            this.lblSite.TabIndex = 2;
            this.lblSite.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(40, 95);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(100, 20);
            this.txtSite.TabIndex = 3;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(64, 141);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 4;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // lblCursoMostrar
            // 
            this.lblCursoMostrar.AutoSize = true;
            this.lblCursoMostrar.Location = new System.Drawing.Point(40, 191);
            this.lblCursoMostrar.Name = "lblCursoMostrar";
            this.lblCursoMostrar.Size = new System.Drawing.Size(37, 13);
            this.lblCursoMostrar.TabIndex = 5;
            this.lblCursoMostrar.Text = "Curso:";
            // 
            // lblSiteMostrar
            // 
            this.lblSiteMostrar.AutoSize = true;
            this.lblSiteMostrar.Location = new System.Drawing.Point(40, 224);
            this.lblSiteMostrar.Name = "lblSiteMostrar";
            this.lblSiteMostrar.Size = new System.Drawing.Size(28, 13);
            this.lblSiteMostrar.TabIndex = 6;
            this.lblSiteMostrar.Text = "Site:";
            this.lblSiteMostrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmCursoAndamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSiteMostrar);
            this.Controls.Add(this.lblCursoMostrar);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.Name = "frmCursoAndamento";
            this.Text = "Curso em andamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Label lblCursoMostrar;
        private System.Windows.Forms.Label lblSiteMostrar;
    }
}