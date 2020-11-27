using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvestmentNow
{
    public partial class FrmConsultaFuncionario : Form
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source =localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
            string cmdConsultar = "Select * from Funcionario where status_func=1";

            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFuncionarios.DataSource = dt;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletarFunc_Click(object sender, EventArgs e)
        {

            var linha = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
            string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
            string cmdDelete = "UPDATE Funcionario SET status_func = 0 where codFunc=" + linha;
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdDelete, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Registro Apagado!");

            string cmdConsultar = "Select * from Funcionario where status_func = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFuncionarios.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var id = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
            var nome = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
            var valor = dgvFuncionarios.CurrentRow.Cells[2].Value.ToString().Replace(",", ".");
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
            //dgvMoedas.DataSource = dt;
        }
    }
}
