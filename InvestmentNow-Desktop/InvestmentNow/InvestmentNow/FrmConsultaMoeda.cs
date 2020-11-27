using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvestmentNow
{
    public partial class FrmConsultaMoeda : Form
    {
        public FrmConsultaMoeda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source =localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
            string cmdConsultar = "Select codMoeda, nome_moeda, valor_moeda from Criptomoeda where status_moeda = 1";
            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMoedas.DataSource = dt;
        }

        private void btnConsultaNome_Click(object sender, EventArgs e)
        {
        
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var linha = dgvMoedas.CurrentRow.Cells[0].Value.ToString();
                string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
                string cmdDelete = "UPDATE Criptomoeda SET status_moeda = 0 where codMoeda=" + linha;
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdDelete, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Registro Apagado!");

                string cmdConsultar = "Select codMoeda, nome_moeda, valor_moeda from Criptomoeda where status_moeda = 1";
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMoedas.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados e tente novamente.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnEditarMoeda_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgvMoedas.CurrentRow.Cells[0].Value.ToString();
                var nome = dgvMoedas.CurrentRow.Cells[1].Value.ToString();
                var valor = dgvMoedas.CurrentRow.Cells[2].Value.ToString().Replace(",", ".");
                string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
                string cmdAtualiza = "UPDATE Criptomoeda SET nome_moeda = '" + nome + "' ,valor_moeda = '" + valor + "' Where codMoeda ='" + id + "'";
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdAtualiza, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Registro Atualizado!");

                string cmdConsultar = "Select codMoeda, nome_moeda, valor_moeda from Criptomoeda where status_moeda = 1";
                SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMoedas.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados e tente novamente.");
            }
        }
    }
}

