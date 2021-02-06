using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_racao
{
    public partial class Tela_novo_usuario : Form
    {
        public Tela_novo_usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_usuario cad2 = new Cadastro_usuario(textBox2.Text, textBox1.Text);
        }
    }
}
