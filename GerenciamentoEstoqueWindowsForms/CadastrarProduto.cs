using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciamentoEstoqueWindowsForms
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnRetornarTelaInicial_Click(object sender, EventArgs e)
        {
            frmTelaInicial frmtelainicial = new frmTelaInicial();
            frmtelainicial.Show();
            this.Hide();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparErros();
        }
        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtPrecoProduto.Text = "";
            txtQuantidadeProduto.Text = "";
            cmbCategoriaProduto.SelectedIndex = -1;
        }
        private void LimparErros()
        {
            lblErroNomeProduto.Text = "";
            lblErroPrecoProduto.Text = "";
            lblErroQuantidadeProduto.Text = "";
            lblErroCategoriaProduto.Text = "";
        }
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao;
            Conexao = new MySqlConnection("datasource=localhost;username=rot;password=;database=teste");
            try
            {
                Conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao conectar com o banco de dados. \nConfira sua conexão com a internet e tente novamente.");
                this.Close();
            }

            string nomeProduto = txtNomeProduto.Text;
            double precoProduto = double.Parse(txtPrecoProduto.Text);
            int quantidadeProduto = int.Parse(txtQuantidadeProduto.Text);
            string categoriaProduto = cmbCategoriaProduto.Text;

            while (nomeProduto.Length < 3)
            {
                lblErroNomeProduto.Visible = true;
                lblErroNomeProduto.Text = "Insira um valor válido";
                break;
            }
            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProduto, categoriaProduto);

            try
            {
                MySqlCommand comando = new MySqlCommand(produto.InserirProdutoBancoDeDados(), Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cliente inserido com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente.");
            }
        }
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
