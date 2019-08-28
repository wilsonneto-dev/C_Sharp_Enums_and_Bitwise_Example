using System;

namespace TestingMultiplesEnums
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Filtro filtro = Filtro.Clips | Filtro.MP3;
            string response = "";

            Console.WriteLine("filtro => Clips | MP3");

            if (filtro == Filtro.Clips) // false
                response = "Clips"; 
            else if (filtro == Filtro.MP3) // false
                response = "MP"; 
            else if (filtro == (Filtro.MP3 | Filtro.Clips))
                response = "Ambos"; // printed



            Console.WriteLine(response);

            Console.WriteLine(filtro & Filtro.MP3); // MP3
            Console.WriteLine(filtro & Filtro.Clips); // Clips
            Console.WriteLine(filtro & Filtro.Movies);

            if ((filtro & Filtro.Movies) != 0)
                Console.WriteLine("movies => diferente de zero");
            else
                Console.WriteLine("movies foi zero");

            if ((filtro & Filtro.MP3) != 0)
                Console.WriteLine("mp3 => diferente de zero");
            else
                Console.WriteLine("mp3 foi zero");

            if (filtro.HasFlag(Filtro.MP3))
                Console.WriteLine("filtros has flag mp3");
            else
                Console.WriteLine("filtros dont has flag mp3");

            if (filtro.HasFlag(Filtro.Movies))
                Console.WriteLine("filtros has flag movies");
            else
                Console.WriteLine("filtros dont has flag movies");

            Console.ReadKey();

        }
    }

    public enum Filtro
    {
        Movies = 1,
        Series = 2,
        Clips = 4,
        MP3 = 8
    }

}
