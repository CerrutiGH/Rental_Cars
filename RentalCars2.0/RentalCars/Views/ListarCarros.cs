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
    public partial class ListarCarros : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        MySqlDataReader rde;
        string strSQL;
        string conexao = "Server=localhost;Database=carroDB;Uid=root;Pwd=Guillherme7003;";





        public ListarCarros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ListarCarros_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            
        }

        private void listarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "select * from tbCarro;";


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

        private void editarCarro_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" && txtName.Text != "" && txtPlate.Text != "" && txtColor.Text != "" && txtPrice.Text != "")
            {
                try
                {
                    con = new MySqlConnection(conexao);
                    strSQL = "UPDATE tbCarro set Brand_Carro = @Brand_Carro, Nome_Carro = @Nome_Carro, Placa_Carro = @Placa_Carro, Cor_Carro = @Cor_Carro, Preco_Carro = @Preco_Carro where Placa_Carro = @Placa_Carro";
                    cmd = new MySqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Brand_Carro", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Nome_Carro", txtName.Text);
                    cmd.Parameters.AddWithValue("@Placa_Carro", txtPlate.Text);
                    cmd.Parameters.AddWithValue("@Cor_Carro", txtColor.Text);
                    cmd.Parameters.AddWithValue("@Preco_Carro", txtPrice.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    txtBrand.Clear();
                    txtName.Clear();
                    txtPlate.Clear();
                    txtPrice.Clear();
                    txtColor.Clear();
                    MessageBox.Show("As informações do carro forão atualizadas!");
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
                MessageBox.Show("Atualize todos os campos");
            }
            
        }

        private void cadastrarCar_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" && txtName.Text != "" && txtPlate.Text != "" && txtColor.Text != "" && txtPrice.Text != "") { 
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "INSERT INTO tbCarro(Brand_Carro, Nome_Carro, Placa_Carro, Cor_Carro, Preco_Carro) VALUES(@Brand_Carro, @Nome_Carro, @Placa_Carro, @Cor_Carro, @Preco_Carro)";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Brand_Carro".Replace(" ", ""), txtBrand.Text);
                cmd.Parameters.AddWithValue("@Nome_Carro".Replace(" ", ""), txtName.Text);
                cmd.Parameters.AddWithValue("@Placa_Carro".Replace(" ", ""), txtPlate.Text);
                cmd.Parameters.AddWithValue("@Cor_Carro".Replace(" ", ""), txtColor.Text);
                cmd.Parameters.AddWithValue("@Preco_Carro".Replace(" ", ""), txtPrice.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                    txtBrand.Clear();
                    txtName.Clear();
                    txtPlate.Clear();
                    txtPrice.Clear();
                    txtColor.Clear();

                    MessageBox.Show("Carro cadastrado!");
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
        

        private void apagarCarro_Click(object sender, EventArgs e)
        {
            if(txtPlate.Text != "") { 
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "DELETE from tbCarro where Placa_Carro = @Placa_Carro";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Placa_Carro", txtPlate.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                txtPlate.Clear();
                MessageBox.Show("Carro deletado!");
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
                MessageBox.Show("Preencha o campo placa!");
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtPlate.Text != "   -") { 
            try
            {
                con = new MySqlConnection(conexao);
                strSQL = "select * from tbCarro where Placa_Carro = @Placa_Carro;";
                cmd = new MySqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Placa_Carro", txtPlate.Text);

                con.Open();
                rde = cmd.ExecuteReader();


                while (rde.Read())
                {
                    txtBrand.Text = Convert.ToString(rde["Brand_Carro"]);
                    txtColor.Text = Convert.ToString(rde["Cor_Carro"]);
                    txtName.Text = Convert.ToString(rde["Nome_Carro"]);
                    txtPlate.Text = Convert.ToString(rde["Placa_Carro"]);
                    txtPrice.Text = Convert.ToString(rde["Preco_Carro"]);
                }
              

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
                MessageBox.Show("Preencha o campo placa!");
            }


        }
    }
 }

