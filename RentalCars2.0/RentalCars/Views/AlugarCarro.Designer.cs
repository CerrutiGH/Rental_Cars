
namespace RentalCars.Views
{
    partial class AlugarCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblplate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.ClienteNome = new System.Windows.Forms.TextBox();
            this.cadastrarCar = new System.Windows.Forms.Button();
            this.listarCarro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voltarListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DI = new System.Windows.Forms.MaskedTextBox();
            this.DF = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.PlacaAluguel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.BackColor = System.Drawing.Color.Transparent;
            this.lblcolor.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcolor.Location = new System.Drawing.Point(192, 165);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(43, 26);
            this.lblcolor.TabIndex = 44;
            this.lblcolor.Text = "CPF";
            this.lblcolor.Click += new System.EventHandler(this.lblcolor_Click);
            // 
            // lblplate
            // 
            this.lblplate.AutoSize = true;
            this.lblplate.BackColor = System.Drawing.Color.Transparent;
            this.lblplate.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplate.Location = new System.Drawing.Point(192, 210);
            this.lblplate.Name = "lblplate";
            this.lblplate.Size = new System.Drawing.Size(60, 26);
            this.lblplate.TabIndex = 43;
            this.lblplate.Text = "Placa";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(119, 116);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(151, 26);
            this.lblname.TabIndex = 42;
            this.lblname.Text = "Nome do Cliente";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Transparent;
            this.lblbrand.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbrand.Location = new System.Drawing.Point(161, 76);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(109, 26);
            this.lblbrand.TabIndex = 41;
            this.lblbrand.Text = "Data Inicial";
            // 
            // ClienteNome
            // 
            this.ClienteNome.Location = new System.Drawing.Point(276, 116);
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.Size = new System.Drawing.Size(190, 20);
            this.ClienteNome.TabIndex = 37;
            // 
            // cadastrarCar
            // 
            this.cadastrarCar.BackColor = System.Drawing.Color.Navy;
            this.cadastrarCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarCar.Location = new System.Drawing.Point(397, 251);
            this.cadastrarCar.Name = "cadastrarCar";
            this.cadastrarCar.Size = new System.Drawing.Size(111, 30);
            this.cadastrarCar.TabIndex = 35;
            this.cadastrarCar.Text = "Cadastrar";
            this.cadastrarCar.UseVisualStyleBackColor = false;
            this.cadastrarCar.Click += new System.EventHandler(this.cadastrarCar_Click);
            // 
            // listarCarro
            // 
            this.listarCarro.BackColor = System.Drawing.Color.LightGreen;
            this.listarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarCarro.Location = new System.Drawing.Point(397, 486);
            this.listarCarro.Name = "listarCarro";
            this.listarCarro.Size = new System.Drawing.Size(111, 46);
            this.listarCarro.TabIndex = 32;
            this.listarCarro.Text = "Atualizar";
            this.listarCarro.UseVisualStyleBackColor = false;
            this.listarCarro.Click += new System.EventHandler(this.listarCarro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 165);
            this.dataGridView1.TabIndex = 31;
            // 
            // voltarListar
            // 
            this.voltarListar.BackColor = System.Drawing.Color.Cyan;
            this.voltarListar.FlatAppearance.BorderSize = 0;
            this.voltarListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.voltarListar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.voltarListar.Location = new System.Drawing.Point(64, 507);
            this.voltarListar.Name = "voltarListar";
            this.voltarListar.Size = new System.Drawing.Size(88, 39);
            this.voltarListar.TabIndex = 30;
            this.voltarListar.Text = "Voltar";
            this.voltarListar.UseVisualStyleBackColor = false;
            this.voltarListar.Click += new System.EventHandler(this.voltarListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Aluguel: Cadastro, Editar, Apagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(381, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Data final";
            // 
            // DI
            // 
            this.DI.Location = new System.Drawing.Point(275, 79);
            this.DI.Mask = "00/00/0000";
            this.DI.Name = "DI";
            this.DI.Size = new System.Drawing.Size(65, 20);
            this.DI.TabIndex = 49;
            this.DI.ValidatingType = typeof(System.DateTime);
            // 
            // DF
            // 
            this.DF.Location = new System.Drawing.Point(472, 79);
            this.DF.Mask = "00/00/0000";
            this.DF.Name = "DF";
            this.DF.Size = new System.Drawing.Size(65, 20);
            this.DF.TabIndex = 50;
            this.DF.ValidatingType = typeof(System.DateTime);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(276, 170);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(82, 20);
            this.txtCPF.TabIndex = 51;
            this.txtCPF.ValidatingType = typeof(System.DateTime);
            // 
            // PlacaAluguel
            // 
            this.PlacaAluguel.Location = new System.Drawing.Point(275, 216);
            this.PlacaAluguel.Mask = "LLL-0000";
            this.PlacaAluguel.Name = "PlacaAluguel";
            this.PlacaAluguel.Size = new System.Drawing.Size(54, 20);
            this.PlacaAluguel.TabIndex = 52;
            this.PlacaAluguel.ValidatingType = typeof(System.DateTime);
            // 
            // AlugarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalCars.Properties.Resources.Design_sem_nome__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PlacaAluguel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.DF);
            this.Controls.Add(this.DI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblplate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.ClienteNome);
            this.Controls.Add(this.cadastrarCar);
            this.Controls.Add(this.listarCarro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voltarListar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "AlugarCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlugarCarro";
            this.Load += new System.EventHandler(this.AlugarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblplate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox ClienteNome;
        private System.Windows.Forms.Button cadastrarCar;
        private System.Windows.Forms.Button listarCarro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voltarListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DI;
        private System.Windows.Forms.MaskedTextBox DF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox PlacaAluguel;
    }
}