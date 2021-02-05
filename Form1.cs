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
    public partial class Form1 : Form
    {
        public Form1()
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
                Form2 f2 = new Form2();
                f2.Show();
                f1 = FindForm();
                f1.Hide();
            }
            else if(ckeEmpresa.Checked)
            {
                Form f1 = new Form();
                Form6 f6 = new Form6();
                f6.Show();
                f1 = FindForm();
                f1.Hide();
            }
            else
            {
                MessageBox.Show("Marque alguma CheckBox");
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
    }
}
