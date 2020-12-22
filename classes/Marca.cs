using System;
using System.Collections.Generic;

namespace Marcas.classes
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }
        
        public List<Marca> Marcas = new List<Marca>();
        
        
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca: ");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca: ");
            NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;
            Marcas.Add(novaMarca);

            return novaMarca;

        }

        public void Listar(){
            Console.WriteLine("Marcas cadastradas: ");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Marca {item.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {item.DataCadastro}");
            }

        }

        public void Deletar(int codigo){
            Marca marcaDelete = Marcas.Find(m => m.Codigo == codigo);
            Marcas.Remove(marcaDelete);

        }
    }
}