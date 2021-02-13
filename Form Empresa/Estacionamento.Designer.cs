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
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.lblEstacionamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estacionamento";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstacionamento;
    }
}