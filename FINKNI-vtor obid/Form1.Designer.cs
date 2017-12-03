namespace FINKNI_vtor_obid
{
    partial class Form1
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
            this.btnAddAKonto = new System.Windows.Forms.Button();
            this.btnModifyAKonto = new System.Windows.Forms.Button();
            this.btnDeleteAKonto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSifraAkonto = new System.Windows.Forms.TextBox();
            this.txtNazivAKonto = new System.Windows.Forms.TextBox();
            this.lblSifraAKonto = new System.Windows.Forms.Label();
            this.lblNazivAKonto = new System.Windows.Forms.Label();
            this.btnNewAKonto = new System.Windows.Forms.Button();
            this.btnKontenPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAKonto
            // 
            this.btnAddAKonto.Location = new System.Drawing.Point(337, 141);
            this.btnAddAKonto.Name = "btnAddAKonto";
            this.btnAddAKonto.Size = new System.Drawing.Size(169, 30);
            this.btnAddAKonto.TabIndex = 0;
            this.btnAddAKonto.Text = "Сними Аналитичко Конто";
            this.btnAddAKonto.UseVisualStyleBackColor = true;
            this.btnAddAKonto.Click += new System.EventHandler(this.btnAddAKonto_Click);
            // 
            // btnModifyAKonto
            // 
            this.btnModifyAKonto.Location = new System.Drawing.Point(337, 189);
            this.btnModifyAKonto.Name = "btnModifyAKonto";
            this.btnModifyAKonto.Size = new System.Drawing.Size(169, 32);
            this.btnModifyAKonto.TabIndex = 1;
            this.btnModifyAKonto.Text = "Измени Аналитичко Конто";
            this.btnModifyAKonto.UseVisualStyleBackColor = true;
            this.btnModifyAKonto.Click += new System.EventHandler(this.btnModifyAKonto_Click);
            // 
            // btnDeleteAKonto
            // 
            this.btnDeleteAKonto.Location = new System.Drawing.Point(337, 237);
            this.btnDeleteAKonto.Name = "btnDeleteAKonto";
            this.btnDeleteAKonto.Size = new System.Drawing.Size(169, 34);
            this.btnDeleteAKonto.TabIndex = 2;
            this.btnDeleteAKonto.Text = "Избриши Аналитичко Конто";
            this.btnDeleteAKonto.UseVisualStyleBackColor = true;
            this.btnDeleteAKonto.Click += new System.EventHandler(this.btnDeleteAKonto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSifraAkonto
            // 
            this.txtSifraAkonto.Location = new System.Drawing.Point(189, 90);
            this.txtSifraAkonto.MaxLength = 10;
            this.txtSifraAkonto.Name = "txtSifraAkonto";
            this.txtSifraAkonto.Size = new System.Drawing.Size(115, 20);
            this.txtSifraAkonto.TabIndex = 4;
            this.txtSifraAkonto.TextChanged += new System.EventHandler(this.txtSifraAkonto_TextChanged);
            // 
            // txtNazivAKonto
            // 
            this.txtNazivAKonto.Location = new System.Drawing.Point(188, 138);
            this.txtNazivAKonto.Name = "txtNazivAKonto";
            this.txtNazivAKonto.Size = new System.Drawing.Size(143, 20);
            this.txtNazivAKonto.TabIndex = 5;
            // 
            // lblSifraAKonto
            // 
            this.lblSifraAKonto.AutoSize = true;
            this.lblSifraAKonto.Location = new System.Drawing.Point(35, 93);
            this.lblSifraAKonto.Name = "lblSifraAKonto";
            this.lblSifraAKonto.Size = new System.Drawing.Size(150, 13);
            this.lblSifraAKonto.TabIndex = 6;
            this.lblSifraAKonto.Text = "Шифра на аналитичко конто";
            // 
            // lblNazivAKonto
            // 
            this.lblNazivAKonto.AutoSize = true;
            this.lblNazivAKonto.Location = new System.Drawing.Point(35, 141);
            this.lblNazivAKonto.Name = "lblNazivAKonto";
            this.lblNazivAKonto.Size = new System.Drawing.Size(147, 13);
            this.lblNazivAKonto.TabIndex = 7;
            this.lblNazivAKonto.Text = "Назив на аналитичко конто";
            // 
            // btnNewAKonto
            // 
            this.btnNewAKonto.Location = new System.Drawing.Point(337, 90);
            this.btnNewAKonto.Name = "btnNewAKonto";
            this.btnNewAKonto.Size = new System.Drawing.Size(169, 31);
            this.btnNewAKonto.TabIndex = 8;
            this.btnNewAKonto.Text = "Ново Аналитичко Конто";
            this.btnNewAKonto.UseVisualStyleBackColor = true;
            this.btnNewAKonto.Click += new System.EventHandler(this.btnNewAKonto_Click);
            // 
            // btnKontenPlan
            // 
            this.btnKontenPlan.Location = new System.Drawing.Point(337, 287);
            this.btnKontenPlan.Name = "btnKontenPlan";
            this.btnKontenPlan.Size = new System.Drawing.Size(170, 35);
            this.btnKontenPlan.TabIndex = 9;
            this.btnKontenPlan.Text = "Види Контен План";
            this.btnKontenPlan.UseVisualStyleBackColor = true;
            this.btnKontenPlan.Click += new System.EventHandler(this.btnKontenPlan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 520);
            this.Controls.Add(this.btnKontenPlan);
            this.Controls.Add(this.btnNewAKonto);
            this.Controls.Add(this.lblNazivAKonto);
            this.Controls.Add(this.lblSifraAKonto);
            this.Controls.Add(this.txtNazivAKonto);
            this.Controls.Add(this.txtSifraAkonto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteAKonto);
            this.Controls.Add(this.btnModifyAKonto);
            this.Controls.Add(this.btnAddAKonto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAKonto;
        private System.Windows.Forms.Button btnModifyAKonto;
        private System.Windows.Forms.Button btnDeleteAKonto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSifraAkonto;
        private System.Windows.Forms.TextBox txtNazivAKonto;
        private System.Windows.Forms.Label lblSifraAKonto;
        private System.Windows.Forms.Label lblNazivAKonto;
        private System.Windows.Forms.Button btnNewAKonto;
        private System.Windows.Forms.Button btnKontenPlan;
    }
}

