using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentNow
{
    public partial class FrmCadastroMoeda : Form
    {
        public FrmCadastroMoeda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorMoeda.Clear();
            txtNomeMoeda.Clear();
        }

        private void txtValorMoeda_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeMoeda.TextLength != 0 && txtValorMoeda.TextLength != 0)
            {
                string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
                string valor = txtValorMoeda.Text.Replace(",", ".");
                string cmdInsert = "INSERT INTO Criptomoeda (nome_moeda,valor_moeda, status_moeda)"
            + "VALUES ('" + txtNomeMoeda.Text + "', '" + valor + "',  '" + 1 + "')";

                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);

                con.Open();
                sqlCommand.ExecuteNonQuery();

                txtValorMoeda.Clear();
                txtNomeMoeda.Clear();
                lblConfirma.Visible = true;
                con.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

        }

        private void txtNomeMoeda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirma_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
