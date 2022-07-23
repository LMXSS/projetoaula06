using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06A.Helpers
{
    /// <summary>
    /// CLASSE PARA AUXILIAR CLASSE DE DADOS ATRAVÉS DO CONSOLE
    /// </summary>
    public static class InputHelper // MÉTODO STATIC RECEBE APENAS STATIC
    {
        public static string Get(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
    }
}
