using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizerParking
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ckeColaborador.Checked)
            {
                Form f1 = new Form();
                FormTelaPrincipal f2 = new FormTelaPrincipal();
                f2.Show();
                f1 = FindForm();
                f1.Hide();
            }
            else if(ckeEmpresa.Checked)
            {
                Form f1 = new Form();
                FormEmpresa f6 = new FormEmpresa();
                f6.Show();
                f1 = FindForm();
                f1.Hide();
            }
            else
            {
                MessageBox.Show("Marque entre Colaborador e Empresa");
            }
           
                
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
