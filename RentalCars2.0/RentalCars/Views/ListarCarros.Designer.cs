
namespace RentalCars.Views
{
    partial class ListarCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarCarros));
            this.label1 = new System.Windows.Forms.Label();
            this.voltarListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listarCarro = new System.Windows.Forms.Button();
            this.editarCarro = new System.Windows.Forms.Button();
            this.apagarCarro = new System.Windows.Forms.Button();
            this.cadastrarCar = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblplate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carros: Cadastro, Editar, Apagar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // voltarListar
            // 
            this.voltarListar.BackColor = System.Drawing.Color.Cyan;
            this.voltarListar.FlatAppearance.BorderSize = 0;
            this.voltarListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.voltarListar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.voltarListar.Location = new System.Drawing.Point(26, 501);
            this.voltarListar.Name = "voltarListar";
            this.voltarListar.Size = new System.Drawing.Size(88, 39);
            this.voltarListar.TabIndex = 5;
            this.voltarListar.Text = "Voltar";
            this.voltarListar.UseVisualStyleBackColor = false;
            this.voltarListar.Click += new System.EventHandler(this.voltarListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 165);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listarCarro
            // 
            this.listarCarro.BackColor = System.Drawing.Color.LightGreen;
            this.listarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarCarro.Location = new System.Drawing.Point(411, 494);
            this.listarCarro.Name = "listarCarro";
            this.listarCarro.Size = new System.Drawing.Size(111, 46);
            this.listarCarro.TabIndex = 7;
            this.listarCarro.Text = "Atualizar";
            this.listarCarro.UseVisualStyleBackColor = false;
            this.listarCarro.Click += new System.EventHandler(this.listarCarro_Click);
            // 
            // editarCarro
            // 
            this.editarCarro.BackColor = System.Drawing.Color.Chartreuse;
            this.editarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarCarro.Location = new System.Drawing.Point(570, 103);
            this.editarCarro.Name = "editarCarro";
            this.editarCarro.Size = new System.Drawing.Size(102, 30);
            this.editarCarro.TabIndex = 9;
            this.editarCarro.Text = "Editar";
            this.editarCarro.UseVisualStyleBackColor = false;
            this.editarCarro.Click += new System.EventHandler(this.editarCarro_Click);
            // 
            // apagarCarro
            // 
            this.apagarCarro.BackColor = System.Drawing.Color.Red;
            this.apagarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagarCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apagarCarro.Location = new System.Drawing.Point(570, 139);
            this.apagarCarro.Name = "apagarCarro";
            this.apagarCarro.Size = new System.Drawing.Size(102, 30);
            this.apagarCarro.TabIndex = 10;
            this.apagarCarro.Text = "Apagar";
            this.apagarCarro.UseVisualStyleBackColor = false;
            this.apagarCarro.Click += new System.EventHandler(this.apagarCarro_Click);
            // 
            // cadastrarCar
            // 
            this.cadastrarCar.BackColor = System.Drawing.Color.Navy;
            this.cadastrarCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarCar.Location = new System.Drawing.Point(570, 69);
            this.cadastrarCar.Name = "cadastrarCar";
            this.cadastrarCar.Size = new System.Drawing.Size(102, 30);
            this.cadastrarCar.TabIndex = 11;
            this.cadastrarCar.Text = "Cadastrar";
            this.cadastrarCar.UseVisualStyleBackColor = false;
            this.cadastrarCar.Click += new System.EventHandler(this.cadastrarCar_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(155, 230);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(63, 26);
            this.lblprice.TabIndex = 27;
            this.lblprice.Text = "Preço";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.BackColor = System.Drawing.Color.Transparent;
            this.lblcolor.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.Location = new System.Drawing.Point(155, 190);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(43, 26);
            this.lblcolor.TabIndex = 26;
            this.lblcolor.Text = "Cor";
            // 
            // lblplate
            // 
            this.lblplate.AutoSize = true;
            this.lblplate.BackColor = System.Drawing.Color.Transparent;
            this.lblplate.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplate.Location = new System.Drawing.Point(155, 150);
            this.lblplate.Name = "lblplate";
            this.lblplate.Size = new System.Drawing.Size(60, 26);
            this.lblplate.TabIndex = 25;
            this.lblplate.Text = "Placa";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(155, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 26);
            this.lblname.TabIndex = 24;
            this.lblname.Text = "Nome";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Transparent;
            this.lblbrand.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(155, 73);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(67, 26);
            this.lblbrand.TabIndex = 23;
            this.lblbrand.Text = "Marca";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(238, 73);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(190, 20);
            this.txtBrand.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(238, 230);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(238, 191);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(190, 20);
            this.txtColor.TabIndex = 21;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Yellow;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(570, 175);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 30);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(238, 150);
            this.txtPlate.Mask = "LLL-0000";
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(59, 20);
            this.txtPlate.TabIndex = 29;
            this.txtPlate.ValidatingType = typeof(int);
            // 
            // ListarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblplate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cadastrarCar);
            this.Controls.Add(this.apagarCarro);
            this.Controls.Add(this.editarCarro);
            this.Controls.Add(this.listarCarro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voltarListar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ListarCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarCarros";
            this.Load += new System.EventHandler(this.ListarCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltarListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listarCarro;
        private System.Windows.Forms.Button editarCarro;
        private System.Windows.Forms.Button apagarCarro;
        private System.Windows.Forms.Button cadastrarCar;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblplate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox txtPlate;
    }
}