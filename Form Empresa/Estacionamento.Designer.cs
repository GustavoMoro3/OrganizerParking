namespace OrganizerParking
{
    partial class Estacionamento
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
            this.lblEstacionamento = new System.Windows.Forms.Label();
            this.lblVagas = new System.Windows.Forms.Label();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.btnVagas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEstacionamento
            // 
            this.lblEstacionamento.AutoSize = true;
            this.lblEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacionamento.Location = new System.Drawing.Point(195, 31);
            this.lblEstacionamento.Name = "lblEstacionamento";
            this.lblEstacionamento.Size = new System.Drawing.Size(251, 38);
            this.lblEstacionamento.TabIndex = 1;
            this.lblEstacionamento.Text = "Estacionamento";
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVagas.Location = new System.Drawing.Point(60, 150);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(208, 25);
            this.lblVagas.TabIndex = 2;
            this.lblVagas.Text = "Quantidade de Vagas ";
            // 
            // txtVagas
            // 
            this.txtVagas.Location = new System.Drawing.Point(331, 150);
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(161, 20);
            this.txtVagas.TabIndex = 3;
            // 
            // btnVagas
            // 
            this.btnVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVagas.Location = new System.Drawing.Point(250, 251);
            this.btnVagas.Name = "btnVagas";
            this.btnVagas.Size = new System.Drawing.Size(170, 32);
            this.btnVagas.TabIndex = 4;
            this.btnVagas.Text = "Cadastrar";
            this.btnVagas.UseVisualStyleBackColor = true;
            this.btnVagas.Click += new System.EventHandler(this.btnVagas_Click);
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.btnVagas);
            this.Controls.Add(this.txtVagas);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.lblEstacionamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estacionamento";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstacionamento;
        private System.Windows.Forms.Label lblVagas;
        private System.Windows.Forms.TextBox txtVagas;
        private System.Windows.Forms.Button btnVagas;
    }
}