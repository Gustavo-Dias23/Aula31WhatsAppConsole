using System;
using System.Collections.Generic;
using System.IO;
namespace Aula30WhatsApp
{
    public class Agenda : iAgenda
    {

       List<Contato> contatos = new List<Contato>();
       private const string PATH = "Database/contatos.csv";
        public Agenda(){
        if(!File.Exists(PATH)){
            File.Create(PATH).Close();
            }
        }
        public void Cadastrar(Contato c)
        {
            var linha = new string[] {PrepararLinhaCSV (c)};
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(Contato c)
        {
            List<string> linhas = new List<string>();
                using(StreamReader arquivo = new StreamReader(PATH)){
            string linha;
            while((linha = arquivo.ReadLine()) !=null){
                linhas.Add(linha);
                }
            linhas.RemoveAll(z => z.Contains (c.Nome)); 
            }
        }

        public void Listar()
        {
            List<Contato> cont = new List<Contato>();
            string[] linhas =  File.ReadAllLines(PATH);

            foreach(string linha in linhas){
                string[] dado = linha.Split(";");

                Contato c = new Contato();
                c.Nome = Separar(dado[0]);
                c.Telefone = Separar(dado[1]);

                cont.Add(c);
            }
        }
        private string PrepararLinhaCSV(Contato c){
            return $"Contato salvo {c.Nome}: {c.Telefone}";
        }
        public string Separar(string dado){
            return dado.Split("=")[1];
        }
    }
}