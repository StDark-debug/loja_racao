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
    public partial class Tela_Login : Form
    {
        Thread nt;

        public Tela_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbPass.Text);
            if (controle.message.Equals("")) { 
            if (controle.exist)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form f = new Tela_Inicio();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos","ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }else
            {
                MessageBox.Show(controle.message);
            }

        }

        private void novoForm()
        {
            Application.Run(new Tela_Inicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
