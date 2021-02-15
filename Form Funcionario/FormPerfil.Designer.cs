namespace OrganizerParking
{
    partial class FormPerfil
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
            this.Perfil = new System.Windows.Forms.Label();
            this.lblPerfilMostrar = new System.Windows.Forms.Label();
            this.lblnomeinformacao = new System.Windows.Forms.Label();
            this.lblcargoinformacao = new System.Windows.Forms.Label();
            this.lblempresainformacao = new System.Windows.Forms.Label();
            this.lblempresa = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil.Location = new System.Drawing.Point(259, 31);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(91, 38);
            this.Perfil.TabIndex = 1;
            this.Perfil.Text = "Perfil";
            // 
            // lblPerfilMostrar
            // 
            this.lblPerfilMostrar.AutoSize = true;
            this.lblPerfilMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPerfilMostrar.Location = new System.Drawing.Point(240, 88);
            this.lblPerfilMostrar.Name = "lblPerfilMostrar";
            this.lblPerfilMostrar.Size = new System.Drawing.Size(140, 25);
            this.lblPerfilMostrar.TabIndex = 2;
            this.lblPerfilMostrar.Text = "Mostrar Perfil";
            this.lblPerfilMostrar.Click += new System.EventHandler(this.lblPerfilMostrar_Click);
            // 
            // lblnomeinformacao
            // 
            this.lblnomeinformacao.AutoSize = true;
            this.lblnomeinformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeinformacao.Location = new System.Drawing.Point(114, 158);
            this.lblnomeinformacao.Name = "lblnomeinformacao";
            this.lblnomeinformacao.Size = new System.Drawing.Size(0, 31);
            this.lblnomeinformacao.TabIndex = 3;
            // 
            // lblcargoinformacao
            // 
            this.lblcargoinformacao.AutoSize = true;
            this.lblcargoinformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargoinformacao.Location = new System.Drawing.Point(114, 207);
            this.lblcargoinformacao.Name = "lblcargoinformacao";
            this.lblcargoinformacao.Size = new System.Drawing.Size(0, 31);
            this.lblcargoinformacao.TabIndex = 4;
            // 
            // lblempresainformacao
            // 
            this.lblempresainformacao.AutoSize = true;
            this.lblempresainformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresainformacao.Location = new System.Drawing.Point(305, 256);
            this.lblempresainformacao.Name = "lblempresainformacao";
            this.lblempresainformacao.Size = new System.Drawing.Size(0, 31);
            this.lblempresainformacao.TabIndex = 5;
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa.Location = new System.Drawing.Point(12, 256);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(287, 31);
            this.lblempresa.TabIndex = 9;
            this.lblempresa.Text = "Distancia da Empresa:";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.Location = new System.Drawing.Point(12, 207);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(96, 31);
            this.lblcargo.TabIndex = 8;
            this.lblcargo.Text = "Cargo:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(14, 158);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(94, 31);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome:";
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblempresainformacao);
            this.Controls.Add(this.lblcargoinformacao);
            this.Controls.Add(this.lblnomeinformacao);
            this.Controls.Add(this.lblPerfilMostrar);
            this.Controls.Add(this.Perfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerfil";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.Label lblPerfilMostrar;
        private System.Windows.Forms.Label lblnomeinformacao;
        private System.Windows.Forms.Label lblcargoinformacao;
        private System.Windows.Forms.Label lblempresainformacao;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnome;
    }
}