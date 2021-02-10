using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrganizerParking
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\suporte\Source\Repos\Gustavolego41\OrganizerParking\Database1.mdf; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();



        public FormLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Verificar e Executar o Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ckeColaborador.Checked)
            {
                conn.Open();
                string select = $"SELECT * FROM Cadastro";
                cmd = new SqlCommand(select, conn);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (Convert.ToString(dr["Usuario"]) == txtUsuario.Text && Convert.ToString(dr["Senha"])==txtPass.Text)
                    {            
                        Form f1 = new Form();
                        FormTelaPrincipal f2 = new FormTelaPrincipal();
                        f2.Show();
                        f1 = FindForm();
                        f1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Inválidos");
                    }
                }
                conn.Close();              
            }
            else if(ckeEmpresa.Checked)
            {
                conn.Open();
                string select = $"SELECT * FROM Cadastro";
                cmd = new SqlCommand(select, conn);
                SqlDataReader dr;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (Convert.ToString(dr["Usuario"]) == txtUsuario.Text && Convert.ToString(dr["Senha"]) == txtPass.Text)
                    {
                        Form f1 = new Form();
                        FormEmpresa f6 = new FormEmpresa();
                        f6.Show();
                        f1 = FindForm();
                        f1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Inválidos");
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Marque entre Colaborador e Empresa");
            }                
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


        //Criar conta 
        private void lbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }




        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
