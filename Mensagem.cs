namespace Aula30WhatsApp
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }
        public Contato Destinatario { get; set; }

        public string Enviar(Contato c){
            return $"Mensagem enviada ao contato {c.Nome} : {Texto}";
        }
    }
}