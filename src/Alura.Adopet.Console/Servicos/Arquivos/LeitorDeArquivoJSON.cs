using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class LeitorDeArquivoJSON : ILeitorDeArquivos
    {
        private string caminhoDoArquivo;

        public LeitorDeArquivoJSON(string caminhoDoArquivo)
        {
            this.caminhoDoArquivo = caminhoDoArquivo;
        }

        public IEnumerable<Pet> RealizaLeitura()
        {
            using var stream = new FileStream(caminhoDoArquivo, FileMode.Open, FileAccess.Read);
            return JsonSerializer.Deserialize<IEnumerable<Pet>>(stream)??Enumerable.Empty<Pet>();
        }
    }
}
