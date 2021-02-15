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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {

        }

        //BOTAO SAIR   


        private void btnSairEmpresa_Click(object sender, EventArgs e)
        {
            FormEmpresa f2 = new FormEmpresa();
            FormLogin f1 = new FormLogin();
            f1.Show();
            this.Close();
            f2.FindForm();
            f2.Hide();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<PerfilEmpresa>();
        }

        private void btnEstacionamento_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Estacionamento>();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Funcionario>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmpresa f2 = new FormEmpresa();
            FormLogin f1 = new FormLogin();
            f1.Show();
            this.Close();
            f2.FindForm();
            f2.Hide();
        }
    }
}
