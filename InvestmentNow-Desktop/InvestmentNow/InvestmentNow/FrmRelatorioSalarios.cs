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
    public partial class FrmRelatorioSalarios : Form
    {
        public FrmRelatorioSalarios()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarTransacoes_Click(object sender, EventArgs e)
        {
        }

        private void btnConsultarLucro_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarSalarios_Click(object sender, EventArgs e)
        {

            string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
            string cmdConsultar = "select f.nome, f.email, f.cpf, f.salario from Funcionario as f where status_func = 1";
            SqlConnection con = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(cmdConsultar, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalarios.DataSource = dt;

            decimal valorTotal = 0;
            foreach (DataGridViewRow col in dgvSalarios.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
            }

            lblTotalLucro.Text = Convert.ToString(valorTotal);
            lblTotalLucro.Visible = true;
            lblSalarios.Visible = true;
        }
    }
}
