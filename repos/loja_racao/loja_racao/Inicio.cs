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
    
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Tela_Cadastro();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cad_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Tela_novo_usuario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
    }

