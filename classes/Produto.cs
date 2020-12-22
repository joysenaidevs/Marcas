using System;
using System.Collections.Generic;

namespace Marcas.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        
        List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){

            Marca Marcas = new Marca();

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            // atribuimos nossa marca atraves de um metodo criado para cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            // atribuimos o usuario através do método construtor
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);



        }
        public void Listar(){
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de cadastro {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado Por: {item.CadastradoPor.Nome}");


            }

        }

        public void Deletar(int _codigo){
            Produto prodDelte = ListaDeProdutos.Find(p => p.Codigo == _codigo);
            ListaDeProdutos.Remove(prodDelte);

        }
        
        
        
        
        
               
        
        
        
        
        
    }
}