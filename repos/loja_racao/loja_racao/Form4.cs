using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace loja_racao
{
    public partial class Form4 : Form
    {
        Thread nt;
        public Form4()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Inicio();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Tela_Cadastro();
            f.Closed += (s, args) => this.Close();
            f.Show();


        }
    }
}
