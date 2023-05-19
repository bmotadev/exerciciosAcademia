using ProgramaLeitorGlicemia;

namespace ProgramaLeitorGlicemia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // solicitar para o usuario o nome e o caminho do arquivo
            string nomeArquivo;

            Console.WriteLine("Digite o caminho e nome do arquivo com dados glicêmicos: ");
            nomeArquivo = Console.ReadLine();


            // necessidade de uma lista de dados glicemicos
            List<Glicemia> listaGlicemia = new List<Glicemia>();

            // capturar linha a linha do arquivo, jogar para um objeto e adicionar na lista
            Persistencia.popularArquivoLista(nomeArquivo, listaGlicemia);

            // exibir os dados da lista
            Comunicacao.listar(listaGlicemia);

            // calcular a media
            Console.WriteLine("A média glicêmica : " + Estatistica.calcularMedia(listaGlicemia));

            // calcular a mediana  antes é preciso ordenar a lista pelo campo valor da glicemia
            Console.WriteLine("A mediana: " + Estatistica.calcularMediana(listaGlicemia));
        }
    }
}