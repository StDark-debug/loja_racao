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
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace loja_racao
{
    public partial class Tela_Cadastro : Form
    {
        Thread nt;
        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Cadastro cad = new Cadastro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Export\\" + "endereco.txt");
            sw.WriteLine(textBox2.Text);
            sw.Close();


            System.Diagnostics.Process.Start("C:/Users/endot/source/repos/loja_racao/loja_racao/bin/Debug/Export/script_api_matrix.py");

            

            string distance = System.IO.File.ReadAllText(Application.StartupPath + "\\Export\\" + "distancia.txt");
            double d_distance = double.Parse(distance, CultureInfo.InvariantCulture);
            double final_distance = (d_distance * 2);

            Console.WriteLine(d_distance);
            Console.WriteLine(final_distance);

            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form4());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

       
    }
}
