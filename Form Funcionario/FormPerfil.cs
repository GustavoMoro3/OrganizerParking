﻿using System;
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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPerfilMostrar_Click(object sender, EventArgs e)
        {
            lblcargoinformacao.Text = "Funcionario Normal";
            lblnomeinformacao.Text = "Josias de Santos";
            lblempresainformacao.Text = "1KM";
            string vaga = "35";
            lblVagainformacao.Text = vaga;
        }

       
    }
}
