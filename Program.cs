using System;

namespace Aula30WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato gustavo = new Contato();
            gustavo.Nome = "Gustavo";
            gustavo.Telefone = "+55 (11) 9999-9999";

            //gustavo.Cadastrar(gustavo);
           
            Contato leonardo = new Contato();
            leonardo.Nome = "Leonardo";
            leonardo.Telefone = "+55 (11) 9888-9888";

           // leonardo.Cadastrar(leonardo);

            Mensagem m1 = new Mensagem();
            m1.Texto = "Boa noite!";
            m1.Destinatario = leonardo;
            
            Console.WriteLine(m1.Enviar( leonardo ));
        }
    }
}
