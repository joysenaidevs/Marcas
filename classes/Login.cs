using System;

namespace Marcas.classes
{
    public class Login
    {
        public bool Logado { get; set; }
        public string Name { get; set; }

        public Login(){
            Usuario user = new Usuario();
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }
        public void GerarMenu(){

            int opcao = 0;


            Marca marca = new Marca();

            Produto produto = new Produto();
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar Produto");
                Console.WriteLine("3 - Deletar Produto");
                Console.WriteLine("4 - Cadastrar Marca");
                Console.WriteLine("5 - Listar Marca");
                Console.WriteLine("6 - Deletar Marca");
                Console.WriteLine("0 - Sair da aplicacao");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                        break;
                    case 2:
                        produto.Listar();
                        break;
                    case 3:
                        Console.WriteLine("Digite um código para excluir");
                        int _codigo = int.Parse(Console.ReadLine());
                        produto.Deletar(_codigo);
                        break;
                    case 4:
                        marca.CadastrarMarca();

                        break;
                    case 5:
                        marca.Listar();
                        break;
                    case 6:
                        Console.WriteLine("Digite um código para deletar marca");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                        break;
                    case 0:
                        Console.WriteLine("Você saiu da aplicação");
                        Console.WriteLine("------------------------------");
                        break;
                    default:
                        break;
                }
                
            } while (opcao != 0);
        }

        
        public void Logar(Usuario usuario){
            Console.WriteLine("Digite seu E-mail ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso!");
            }else{
                Console.WriteLine("Falha ao logar na aplicacao!");
            }
        }

        // public Deslogar(){
        //     Logado = false;
        // }
        
        
        
        
    }
}