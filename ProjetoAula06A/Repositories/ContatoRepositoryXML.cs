using ProjetoAula06A.Entities;
using ProjetoAula06A.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula06A.Repositories
{
    public class ContatoRepositoryXML : BaseRepository<Contato>
    {
        public override void Exportar(Contato obj)
        {
            //Serializar XML 

            var xml = new XmlSerializer(typeof(Contato));

            using (var streamWriter = new StreamWriter($"c:\\temp\\contato_{obj.IdContato}.xml"))
            {
                //escrevendo o conteudo do arquivo
                xml.Serialize(streamWriter, obj);
            }
        }
    }
}


