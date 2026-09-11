using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public interface INotificacao
    {
        void Enviar();
    }
    public class NotificacaoEmail : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por email...");
        }

        public void Enviar(string anexo)
        {
            Console.WriteLine($"Enviando email com anexo: {anexo}");
        }
    }

    public class NotificacaoSMS : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }

    public class NotificacaoPush : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação push para o app...");
        }
    }
}