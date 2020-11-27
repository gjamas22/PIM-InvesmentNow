using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentNow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (submenuFunc.Visible)
            {
                submenuFunc.Visible = false;
            }
            else 
            {
                submenuFunc.Visible = true;
            }
            
        }

        private void btnCadastroMoeda_Click(object sender, EventArgs e)
        {
            if (submenuMoeda.Visible)
            {
                submenuMoeda.Visible = false;
            }
            else
            {
                submenuMoeda.Visible = true;
            }
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            FrmConsultaFuncionario consultaFunc = new FrmConsultaFuncionario();
            consultaFunc.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario cadastroFunc = new FrmCadastroFuncionario();
            cadastroFunc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroMoeda cadastroMoeda = new FrmCadastroMoeda();
            cadastroMoeda.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (submenuRelatorio.Visible)
            {
                submenuRelatorio.Visible = false;
            }
            else
            {
                submenuRelatorio.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaMoeda consultaMoeda = new FrmConsultaMoeda();
            consultaMoeda.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRelatorioTransacoes transacoes = new FrmRelatorioTransacoes();
            transacoes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRelatorioSalarios salarios = new FrmRelatorioSalarios();
            salarios.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (submenuLogin.Visible)
            {
                submenuLogin.Visible = false;
            }
            else
            {
                submenuLogin.Visible = true;
            }
        }

        private void btnCadastroLogin_Click(object sender, EventArgs e)
        {
            FrmCadastroLogin login = new FrmCadastroLogin();
            login.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
     
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Hide();
            }

            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
