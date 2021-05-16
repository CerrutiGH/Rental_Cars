
namespace RentalCars.Views
{
    partial class Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao));
            this.label1 = new System.Windows.Forms.Label();
            this.voltarDevolucao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDevolv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devolução";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // voltarDevolucao
            // 
            this.voltarDevolucao.BackColor = System.Drawing.Color.Cyan;
            this.voltarDevolucao.FlatAppearance.BorderSize = 0;
            this.voltarDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.voltarDevolucao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.voltarDevolucao.Location = new System.Drawing.Point(12, 413);
            this.voltarDevolucao.Name = "voltarDevolucao";
            this.voltarDevolucao.Size = new System.Drawing.Size(88, 39);
            this.voltarDevolucao.TabIndex = 6;
            this.voltarDevolucao.Text = "Voltar";
            this.voltarDevolucao.UseVisualStyleBackColor = false;
            this.voltarDevolucao.Click += new System.EventHandler(this.voltarDevolucao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Location = new System.Drawing.Point(402, 405);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 39);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Atualizar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDevolv
            // 
            this.btnDevolv.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDevolv.FlatAppearance.BorderSize = 0;
            this.btnDevolv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDevolv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDevolv.Location = new System.Drawing.Point(461, 144);
            this.btnDevolv.Name = "btnDevolv";
            this.btnDevolv.Size = new System.Drawing.Size(88, 30);
            this.btnDevolv.TabIndex = 10;
            this.btnDevolv.Text = "Devolver";
            this.btnDevolv.UseVisualStyleBackColor = false;
            this.btnDevolv.Click += new System.EventHandler(this.btnDevolv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(337, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(391, 150);
            this.txtPlaca.Mask = "LLL-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(50, 20);
            this.txtPlaca.TabIndex = 13;
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDevolv);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voltarDevolucao);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Devolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltarDevolucao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnDevolv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
    }
}