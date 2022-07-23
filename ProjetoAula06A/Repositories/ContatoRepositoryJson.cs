using Newtonsoft.Json;
using ProjetoAula06A.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06A.Repositories
{
    /// <summary>
    /// Classe para exportação de dados de contato para arquivo JSON
    /// </summary>
    public class ContatoRepositoryJson : BaseRepository<Contato>
    {
        public override void Exportar(Contato obj)
        {
            //serializar os dados do contato para o formato JSON
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            //abrindo o arquivo e gravando os dados
            using (var streamWriter = new StreamWriter($"c:\\temp\\contato_{obj.IdContato}.json"))
            {
                //escrevendo o conteudo do arquivo
                streamWriter.WriteLine(json);
            }
        }
    }
}

