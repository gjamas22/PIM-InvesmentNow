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
    public partial class FrmCadastroLogin : Form
    {
        public FrmCadastroLogin()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (txtEmailUser.TextLength != 0 && txtSenhaUser.TextLength != 0)
            {
                if (txtSenhaUser.Text.Length < 6)
                {
                    MessageBox.Show("Mínimo 6 caracteres");
                    txtSenhaUser.Focus();
                }
                else
                {
                    string strConexao = "Data Source =localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
                    string cmdInsert = "INSERT INTO Login (usuario,senha) VALUES ('" + txtEmailUser.Text + "', '" + txtSenhaUser.Text + "')";

                    SqlConnection con = new SqlConnection(strConexao);
                    SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);

                    con.Open();
                    sqlCommand.ExecuteNonQuery();

                    txtEmailUser.Clear();
                    txtSenhaUser.Clear();
                    MessageBox.Show("Dados salvos!");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

         }
        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtEmailUser.Clear();
            txtSenhaUser.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
