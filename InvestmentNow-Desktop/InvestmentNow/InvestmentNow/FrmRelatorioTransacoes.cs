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
    public partial class FrmRelatorioTransacoes : Form
    {
        public FrmRelatorioTransacoes()
        {
            InitializeComponent();
        }

        private void dgvMoedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarTransacoes_Click(object sender, EventArgs e)
        {
            string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
            string cmdConsultar = "select cl.nome, cl.email, t.valor_investido, t.quantidade_moedas, m.nome_moeda, m.valor_moeda from Transacao as t INNER JOIN Carteira as c on t.codCarteira = c.codCarteira INNER JOIN Criptomoeda as m on m.codMoeda = t.codMoeda INNER JOIN Cliente as cl  on cl.codCliente = t.codCliente";

            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTransacoes.DataSource = dt;

           decimal valorTotal = 0;
            foreach (DataGridViewRow col in dgvTransacoes.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }

            lblTotal.Text = Convert.ToString(valorTotal);
            lblTotal.Visible = true;
            lblInvestido.Visible = true;
    }

         private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
