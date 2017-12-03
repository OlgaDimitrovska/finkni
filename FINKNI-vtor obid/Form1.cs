using FINKNI_Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FINKNI_vtor_obid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public AnalitickoKonto akonto;

        private void btnAddAKonto_Click(object sender, EventArgs e)
        {
            
            akonto = new AnalitickoKonto();
            this.PutAKontoData(akonto);
            if (string.IsNullOrWhiteSpace(txtSifraAkonto.Text))
            {
                MessageBox.Show("Текст полињата се празни");

            }
            else
            {
                try
                {

                    akonto.SifraNaAKonto = AnalitickoKontoDB.AddAnalitickoKonto(akonto).ToString();
                    MessageBox.Show("Аналитичкото Конто е успешно снимено");
                    this.ClearControls();
                    btnDeleteAKonto.Enabled = true;
                    btnModifyAKonto.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            DisplayData();
        }

        private void PutAKontoData(AnalitickoKonto akonto)
        {
            akonto.SifraNaAKonto = Convert.ToString(txtSifraAkonto.Text);
            akonto.NazivNaAKonto = txtNazivAKonto.Text;
        }

        public void ClearControls()
        {
            txtSifraAkonto.Text = "";
            txtNazivAKonto.Text = "";
        }

        private void DisplayData()
        {
            List<AnalitickoKonto> akonta= AnalitickoKontoDB.GetAKonta();
            dataGridView1.DataSource = akonta;
        }

        private void btnModifyAKonto_Click(object sender, EventArgs e)
        {
            akonto = new AnalitickoKonto();
            this.PutAKontoData(akonto);
           
                try
                {


                    if (!AnalitickoKontoDB.UpdateAnalitickoKonto(akonto))
                        MessageBox.Show("Нема запис " +
                                    "со даденото ID.", "Database Error");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            DisplayData();
        }

        private void btnDeleteAKonto_Click(object sender, EventArgs e)
        {
            akonto = new AnalitickoKonto();
            this.PutAKontoData(akonto);
            
            try
            {

                if (!AnalitickoKontoDB.DeleteAnalitickoKonto(akonto))
                       MessageBox.Show("Нема запис " +
                                 "со даденото ID.", "Database Error");
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            this.ClearControls();
            DisplayData();
        }

        private void btnNewAKonto_Click(object sender, EventArgs e)
        {
            
            this.ClearControls();
            btnModifyAKonto.Enabled = false;
            btnDeleteAKonto.Enabled = false;
        }

        private void txtSifraAkonto_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(txtSifraAkonto.Text, "^[0-9]*$"))
            {
                txtSifraAkonto.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AnalitickoKonto> akonta = AnalitickoKontoDB.GetAKonta();
            dataGridView1.DataSource = akonta;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                txtSifraAkonto.Text = row.Cells[0].Value.ToString();
                txtNazivAKonto.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnKontenPlan_Click(object sender, EventArgs e)
        {
            Form2 forma=new Form2();
            forma.Show();
        }
    }
}
