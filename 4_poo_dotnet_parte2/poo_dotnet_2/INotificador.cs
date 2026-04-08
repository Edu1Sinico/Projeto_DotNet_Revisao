using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_dotnet_2
{
    // Definindo interface
    public interface INotificador
    {
        // Apenas assinaturas (sem corpo)
        void EnviarNotificacao(string mensagem);
        bool ValidarDestinatario(string destinatario);

        // Propriedades (só get/set, sem implementação)
        string TipoNotificacao { get; }
    }

    
    // Implementando interface
    public class EmailNotificador : INotificador
    {
        public string TipoNotificacao => "Email";

        public void EnviarNotificacao(string mensagem)
        {
            Console.WriteLine($"Enviando email: {mensagem}");
        }

        public bool ValidarDestinatario(string destinatario)
        {
            return destinatario.Contains("@");
        }
    }
    // Classe DEVE implementar TODOS os membros da interface
}