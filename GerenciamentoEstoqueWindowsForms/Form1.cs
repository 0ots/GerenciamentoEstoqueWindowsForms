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
    public partial class frmTelaInicial : Form
    {
        MySqlConnection Conexao;
        frmCadastrarProduto frmcadastrarproduto = new frmCadastrarProduto();
        public frmTelaInicial()
        {
            InitializeComponent();
        }
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=teste");
            try
            {
                Conexao.Open();
                frmcadastrarproduto.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao conectar com o banco de dados. \nConfira sua conexão com a internet e tente novamente.");
            }
        }
        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
