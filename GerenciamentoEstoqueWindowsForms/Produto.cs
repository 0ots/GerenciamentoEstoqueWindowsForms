using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciamentoEstoqueWindowsForms
{
    internal class Produto
    {
        // Definição de atributos e métodos automatizados
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public string Categoria { get; private set; }

        // Definição do construtor
        public Produto(string nome, double preco, int quantidade, string categoria)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Categoria = categoria;
        }

        // Propriedades personalizads


        // Método

        public string InserirProdutoBancoDeDados()
        {
            return $"INSERT INTO produto(nome, preco, quantidade, categoria) VALUES('{Nome}', {Preco}, {Quantidade}, '{Categoria}')";
        }
        public string DeletarProdutoBancoDedados()
        {
            return $"DELETE FROM produto where id = ";
        }
    }


}
