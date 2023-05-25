using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Fixacao_mvc.Model
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descrição { get; set; }
        public string? DataEvento { get; set; }


        // "DECLARA" A VARIAVEL QUE NESSE CASO SERIA O CAMINHO, "DECLARA" O CAMINHO!!
        private const string CAMINHO = "Database/Evento.csv";

        public Evento()
        {
            //criar lógica p/ gerar pasta e arquivo csv

            //caminho da pasta
            string pasta = CAMINHO.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //caminho do arquivo
            if (!File.Exists(CAMINHO))
            {
                File.Create(CAMINHO);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventoo = new List<Evento>();

            string[] linhasCsv = File.ReadAllLines(CAMINHO);

            foreach (var item in linhasCsv)
            {
                string[] atributos = item.Split(";");

                Evento e1 = new Evento();

                e1.Nome = atributos[0];
                e1.Descrição = atributos[1];
                e1.DataEvento = (atributos[2]);

                eventoo.Add(e1);
            }

            return eventoo;
        }


        //prepara linhas a serem inseridas no arquivo CSV
        public string PrepararLinhasCSV(Evento eve)
        {
            return $"{eve.Nome};{eve.Descrição};{eve.DataEvento}";
        }

        public void Inserir(Evento even)
        {
            string[] linhas = { PrepararLinhasCSV(even) };

            File.AppendAllLines(CAMINHO, linhas);
        }
    }
}