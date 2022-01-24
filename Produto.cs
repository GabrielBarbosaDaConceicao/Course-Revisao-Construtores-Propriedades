using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cource_Revisao_Const_Prop
{
    internal class Produto
    {
        // Atributos da classe Produto;
        private string _nome { get; set; }
        private double _preco { get; set; }
        private int _quantidade { get; set; }

        // Construtor (PADRÃO) vazio;
        public Produto()
        {

        }
        // Construtor (PERSONALIZADO) com 3 atributos;
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        // Construtor (PERSONALIZADO) com 2 atributos;
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; // Não se faz nescessario adicionar esse atributo,  por convenção valores numéricos recebem 0;
        }
        // Propriedade get e set para o atributo Nome, com uma condição para validação;
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) // Se for maior que 2 caracteres e não for Nulo;
                    _nome = value; 
            }
        }
        // Propriedade get e set para o atributo Preco;
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        // Propriedade get e set para o atributo Quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        // Metodo que retorna o estoque total em valores;
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        // Metodo para adicionar produtos ao estoque;
        public void AdicionarProdutos(int quantidade)
        {
            //  Quantidade += quantidade; OU > Quantidade = Quantidade + quantidade;
            _quantidade = _quantidade + quantidade;
        }
        // Metodo para remover produtos do estoque;
        public void RemoverProdutos(int quantidade)
        {
            //  Quantidade -= quantidade; OU > Quantidade = Quantidade - quantidade;
            _quantidade = _quantidade - quantidade;
        }

        // Um metodo personalizado da classe para mostrar os dados na tela;
        public override string ToString()
        {
            return $"Nome: {_nome.ToUpper()}, Preço: {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} " +
                $"unidades, Valor total em estoque: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
