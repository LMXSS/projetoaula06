using ProjetoAula06A.Controllers;

namespace ProjetoAula06A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contatoController = new ContatoController();
            contatoController.CadastrarContato();

            Console.ReadKey();
        }

         
    }
}