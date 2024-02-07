using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05_c_.noteped
{
    internal class ObjectUser
    {
        public string ArquivName { get; private set; }
        public string Conteudo { get; private set; }

        public ObjectUser (string arquivname,  string conteudo)
        {
            ArquivName = arquivname;
            Conteudo = conteudo;
        }

        public void Save(string Arquivo)
        {
            Conteudo = Arquivo;
        } 

        public void ModificName (string name)
        {
            ArquivName = name;
        }
    }
}
