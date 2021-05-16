using RentalCars.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AlugarCarro();
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ListarCarros();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form f = new Devolucao();
                f.Closed += (s, args) => this.Close();
                f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
