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
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
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




        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

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




        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormPerfil>();
        }


       

        private void btnCaronas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormCarona>();
        }

        private void btnSairPrincipal_Click(object sender, EventArgs e)
        {

            FormTelaPrincipal f2 = new FormTelaPrincipal();
            FormLogin f1 = new FormLogin();
            f1.Show();
            this.Close();
            f2.FindForm();
            f2.Hide();
        }

       
    }
}
