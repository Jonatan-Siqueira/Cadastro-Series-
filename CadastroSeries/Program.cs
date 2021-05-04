using System;


namespace CadastroSeries
{
    class Program
    {
        enum Menu { ação = 1, Aventura, Romance, Anime, Dorama, Sair }
        static void Main(string[] args)
        {
            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("================================");
                Console.WriteLine("Catalogos de filmes");
                Console.WriteLine("Gênero: ");

                Console.WriteLine("1-Ação\n2-Aventura\n3-Romance\n4-Anime\n5-Dorama\n6-Sair");
                Console.WriteLine("==========================");
                string Op = Console.ReadLine();
                int Opint = int.Parse(Op);
                Console.WriteLine("==========================");

                Menu Option = (Menu)Opint;

                if (Opint > 0 && Opint < 6)
                {
                    switch (Option)
                    {
                        case Menu.ação:
                            Acao();
                            break;
                        case Menu.Aventura:
                            Aventura();
                            break;
                        case Menu.Romance:
                            Romance();
                            break;
                        case Menu.Anime:
                            Anime();
                            break;
                        case Menu.Dorama:
                            Dorama();
                            break;
                        case Menu.Sair:
                            Exit = true;
                            break;
                    }
                }
                else
                {
                    Exit = true;
                }
                Console.Clear();
            }
        }
        static void Acao()
        {
            Series serie = new Series();
            serie.Acao();

            Console.ReadLine();
        }
        static void Anime()
        {
            Series Serie = new Series();
            Serie.Anime("Your Name", 2018, "UM jovem volta 300 anos no passado");

            Console.ReadLine();
        }
        static void Aventura()
        {
            Series serie = new Series();
            serie.Aventura("Maze Runner", 2017, "UM jovem preso em um Labirinto");

            

            Console.ReadLine();
        }
        static void Romance()
        {
            Series serie = new Series();
            serie.Romance("A culpa é das Estrelas", 2015, "UMa jovem com Cancer Luta");

            Console.ReadLine();
        }
        static void Dorama()
        {
            Series serie = new Series();
            serie.Dorama("Uma Odisseia Coreana", 2016, "Son oh gong Enifim é libertado da prisão eterna, mas nem tudo é como ele imagina até ele conhecer janmgang");

            Console.ReadLine();
        }
    }
}
