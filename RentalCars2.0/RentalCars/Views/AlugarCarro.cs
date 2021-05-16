using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCars.Views
{
    public partial class AlugarCarro: Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        string strSQL;
        string conexao = "Server=localhost;Database=carroDB;Uid=root;Pwd=Guillherme7003;";


        public AlugarCarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblcolor_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarCar_Click(object sender, EventArgs e)
        {
            if (DI.Text != "" && DF.Text != "" && ClienteNome.Text != "" && txtCPF.Text != "" && PlacaAluguel.Text != "") { 
                try { 


                con = new MySqlConnection(conexao);
                strSQL = "INSERT INTO tbAluguel(Data_Inicial, Data_Final, Cliente_Nome, Cliente_CPF, Placa_Carro) VALUES(@Data_Inicial, @Data_Final, @Cliente_Nome, @Cliente_CPF, @Placa_Carro);" + "UPDATE tbCarro set Disponivel_Carro = 'n' where Placa_Carro = @Placa_Carro;";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Data_Inicial", DateTime.Parse(DI.Text).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Data_Final", DateTime.Parse(DF.Text).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Cliente_Nome", ClienteNome.Text);
                cmd.Parameters.AddWithValue("@Cliente_CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("@Placa_Carro", PlacaAluguel.Text);

                con.Open();
                cmd.ExecuteNonQuery();


                DI.Clear();
                DF.Clear();
                txtCPF.Clear();
                PlacaAluguel.Clear();
                ClienteNome.Clear();
                MessageBox.Show("Carro alugado!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    con = null;
                    cmd = null;
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }


        }

        private void listarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "select * from tbCarro where Disponivel_Carro = 's'";


                adp = new MySqlDataAdapter(strSQL, con);

                DataTable dt = new DataTable();

                adp.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con = null;
                cmd = null;
            }
        }

        private void voltarListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void DI_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlugarCarro_Load(object sender, EventArgs e)
        {

        }
    }
}

