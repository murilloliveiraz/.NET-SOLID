using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Servicos
{
    public class LeitorDeArquivoFactoryTest
    {
        [Fact]
        public void QuantoExtensaoForCsvDeveRetornarTipoLeitorDeArquivoCsv()
        {
            // arrange
            string caminhoArquivo = "pets.csv";

            // act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            // assert
            Assert.IsType<LeitorDeArquivoCSV>(leitor);
        }

        [Fact]
        public void QuantoExtensaoForJsonDeveRetornarTipoLeitorDeArquivoJson()
        {
            // arrange
            string caminhoArquivo = "pets.json";

            // act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            // assert
            Assert.IsType<LeitorDeArquivoJSON>(leitor);
        }

        [Fact]
        public void QuantoExtensaoNaoSuportadaDeveRetornarNulo()
        {
            // arrange
            string caminhoArquivo = "pets.xsl";

            // act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            // assert
            Assert.Null(leitor);
        }

    }
}
