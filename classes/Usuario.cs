using System;

namespace Marcas.classes
{
    public class Usuario
    {
        public Usuario(){
            //Cadastrar usuario automaticamente quando esta classe for instanciada
            Cadastrar();
        }
        public Usuario(int codigo, string senha, string nome, string email ){
            //PASSANDO ARGUMENTOS
            Codigo = codigo;
            Nome = nome;
            Senha = senha;
            Email = email;
            DataCadastro = DateTime.UtcNow;

        }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            Nome = "Joyce";
            Email = "joycessilva17@hotmail.com";
            Senha = "jjjjj";

        }

        public void Deletar(int cod){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000.000.0000.000");

        }
    }
}