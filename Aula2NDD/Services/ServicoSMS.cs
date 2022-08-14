using System;
using Aula2NDD.Infra;
namespace Aula2NDD.Services

{
    public class ServicoSMS
    {
        // verificar se o sms foi enviado com suecesso, se aconteceu alguma falha etc
        private readonly LogAcao _logAcao;
        // injetando dependencia do logacao
        public ServicoSMS (LogAcao logAcao)
        {
            _logAcao = logAcao;
        }

        public void Enviar (string texto)
        {
            // enviando sms
            _logAcao.GravarLog ("SMS enviado com sucesso!");
        }
    }
}

