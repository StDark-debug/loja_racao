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
            
            double final_distance = Conexao_API();
            double frete = 0.17 * final_distance;
            Math.Round(frete, 2);
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");

            Cadastro cad = new Cadastro(txt_box_cliente.Text, txt_box_rua.Text, txt_box_valor.Text, txt_box_telefone.Text, txt_box_cpf.Text, txt_box_num.Text,
                Combox_Cidade.Text, Combox_Bairro.Text, Combox_UF.Text, final_distance, frete, date);
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Tela_Outra_Entrega());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_box_cliente.ForeColor = Color.Black;
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
            txt_box_cliente.Text = "";
            txt_box_cliente.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Conexao_API();
            double final_distance = Conexao_API();
            bool adc_frete;

            //Colocar os cálculos do frete aqui!

            string distancia = final_distance.ToString("0.#");
            
            label14.Text = (distancia + " km");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {

        }
        public double Conexao_API()
        {
            string End_API = (txt_box_rua.Text + " " + txt_box_num.Text + " " + Combox_Bairro.Text + " " + Combox_Cidade.Text + " " + Combox_UF.Text);
            
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Export\\" + "endereco.txt");
            sw.WriteLine(End_API);
            sw.Close();


            System.Diagnostics.Process.Start(Application.StartupPath + "\\Export\\" + "script_api_matrix.pyw");

            Thread.Sleep(800);

            string distance = System.IO.File.ReadAllText(Application.StartupPath + "\\Export\\" + "distancia.txt");
           
            double d_distance = double.Parse(distance, CultureInfo.InvariantCulture);
            double final_distance = (d_distance * 2);

            
            return final_distance;
            

        }
    }
}
