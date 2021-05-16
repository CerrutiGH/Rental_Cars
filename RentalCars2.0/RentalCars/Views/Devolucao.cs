using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentalCars.Views
{
    public partial class Devolucao : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        string strSQL;
        string conexao = "Server=localhost;Database=carroDB;Uid=root;Pwd=Guillherme70033;";

        public Devolucao()
        {
            InitializeComponent();
        }

        private void voltarDevolucao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "select * from tbAluguel;";

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

        private void btnDevolv_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "DELETE FROM tbAluguel where Placa_Carro = @Placa_Carro;" + "UPDATE tbCarro set Disponivel_Carro = 's' where Placa_Carro = @Placa_Carro;";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Placa_Carro", txtPlaca.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Carro devolvido!");

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
            txtPlaca.Clear();
        }
    }
}
