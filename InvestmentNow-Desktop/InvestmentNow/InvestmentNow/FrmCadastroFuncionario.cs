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
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            TxtCpf.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            dtDataContratacao.Value = DateTime.Now;
            dtDataNascimento.Value = DateTime.Now;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "Data Source = localhost; Initial Catalog=INVESTMENTNOW; Integrated Security=True";
                string salario = txtSalario.Text.Replace(",", ".");

                TxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var cpfSemMascara = TxtCpf.Text;

                txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var cepSemMascara = txtCep.Text;

                txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var telefoneSemMascara = txtTelefone.Text;

                DateTime atual = DateTime.Now;
                var aniversario = dtDataNascimento.Value;
                var idade = atual.Year - aniversario.Year;
                if (idade < 18)
                  {
                      dtDataNascimento.Focus();
                      MessageBox.Show("Somente maiores de idade");
                      return;
                  }
            
                if (dtDataContratacao.Value > atual)
                {
                    dtDataContratacao.Focus();
                    MessageBox.Show("Data da contratação não pode ser maior que a atual");
                    return;
                }

                string cmdInsert = "INSERT INTO Funcionario(nome, sexo, data_nasc, data_admissao, email, cpf, salario, celular, cep, uf, cidade, bairro, logradouro, num_residencia, status_func)"
                    + "VALUES ('" + txtNome.Text + "', '" + cboGenero.Text + "', '" + dtDataNascimento.Value + "', '" + dtDataContratacao.Value + "', '" + txtEmail.Text + "', '" + cpfSemMascara
                    + "', '" + salario + "', '" + telefoneSemMascara + "', '" + cepSemMascara + "', '" + cbUf.Text + "','" + txtCidade.Text + "', '" + txtBairro.Text + "', '" + txtEndereco.Text
                    + "', '" + txtNumero.Text + "', '" + 1 + "')";


                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                lblConfirma.Visible = true;
                txtNome.Clear();
                TxtCpf.Clear();
                txtEmail.Clear();
                txtSalario.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtCep.Clear();
                txtCidade.Clear();
                txtBairro.Clear();
                dtDataContratacao.Value = DateTime.Now;
                dtDataNascimento.Value = DateTime.Now;
            }

            catch (Exception)
            {
                MessageBox.Show("Verifique todos os campos");
            }
            
            
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
