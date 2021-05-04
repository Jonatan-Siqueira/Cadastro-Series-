using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries
{
    class Series
    {
        public string Nome;
        public int Ano;
        public string Descrição;

        public void Acao()
        {
            Nome = "Jump Sky";
            Ano = 2019;
            Descrição = "Um Homem Que Fará de Tudo para Salvar sua familia";

            Console.WriteLine(">>>> Filme De Ação <<<<");
            Console.WriteLine("=======================");

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Descrição: {Descrição}");
        }
        public void Aventura(string Nome, int Ano, string Descrição)
        {
            Console.WriteLine(">>>> Filmes de Aventura <<<<");
            Console.WriteLine("=======================");

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Descrição: " + Descrição);
        }
        public void Anime(string Nome, int Ano, string Descrição)
        {
            Console.WriteLine(">>>> Filmes de Anime <<<<");
            Console.WriteLine("=======================");

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Descrição: " + Descrição);

        }
        public void Romance(string Nome, int Ano, string Descrição)
        {
            Console.WriteLine(">>>> Filmes de Romance <<<<");
            Console.WriteLine("=======================");

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Descrição: " + Descrição);
        }
        public void Dorama(string Nome, int Ano, string Descrição)
        {
            Console.WriteLine(">>>> Dorama <<<<");
            Console.WriteLine("=======================");

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Descrição: " + Descrição);
        }
    }

}
