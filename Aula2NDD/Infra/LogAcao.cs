using System;
namespace Aula2NDD.Infra
{
    public class LogAcao
    {
        public string CaminhoArquivo { get; set; }

        public LogAcao (string caminhoArquivo)
        {
            CaminhoArquivo = caminhoArquivo;
        }

        public void GravarLog (string texto)
        {
            // aqui gravaira o arquvio no texto
        }
    }
}

