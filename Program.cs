using Cource_Revisao_Const_Prop;
using System;
using System.Globalization;
namespace Course_Revisao_Const_Prop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Já instânciei meu construtor personalizado com um nome padrão (Produto, Preco(0.0) e Quantidade(0);
            // CONSTRUTOR PERSONALIZADO 1º OPÇÃO;
            //Produto p = new Produto("Produto", 0.0, 0);

            //Console.WriteLine("\nDados do produto : " + p);

            // Setar dados dos produtos: Nome, Preco e quantidade;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //(CONSTRUTOR PERSONALIZADO 2º OPÇÃO)
            // Aqui poderia instânciar meu construtor personalizado, conforme vou recebendo os atributos no conlsole;

            // Construtor padrão vazio / como sobrecarga de construtores
            Produto p2 = new Produto();

            // Costrutor personalizado com 3 atributos ja instânciados (Nome: "Carro",Preco: 35000.00, 20);
            Produto p3 = new Produto();
            p3.Nome ="Carro";
            p3.Preco = 35000.00;
            p3.Quantidade = 20;
            
            
            Console.WriteLine("\nDados do produto : " + p);

            // Setar adicionar e remover produtos
            Console.Write("\nDigite o numero de produtos a ser adicionado no estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o numero de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            // Mostra na tela os dados do produto do objeto da classe p;
            Console.WriteLine("\nDados atualizados: " + p);

            // Mostra na tela os dados do produto do objeto da classe p3;
            Console.WriteLine("\nDados atualizados: " + p3);
        }
    }
}