using MongoDB.Bson;

namespace MongoDB
{
    public class Program
    {
        public ObjectId Id { get; set; }
        public static string Arc { get; set; }
        public static int StartonChapter { get; set; }
        public static int TotalChapters { get; set; }
        public static int TotalPages { get; set; }
        public static string MangaPercent { get; set; }
        public static int StartonEpisode { get; set; }
        public static int TotalEpisodes { get; set; }
        public static int TotalMinutes { get; set; }
        public static string AnimePercent { get; set; }
        
        static void Main(string[] args)
        {
            Console.Write("Gebe den Namen des Arcs ein:");
            Arc = Console.ReadLine();
            
            Console.Write("Gebe das 1. Chapter des Mangas ein:");
            StartonChapter = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe die Anzahl Chapters ein:");
            TotalChapters = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe die gesamte Seitenanzahl des Arcs ein:");
            TotalPages = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe an wie viel vom Manga der Arc in Anspruch nimmt:");
            MangaPercent = Console.ReadLine();
            
            Console.Write("Gebe das 1. Episode des Animes ein:");
            StartonEpisode = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe die Anzahl Episoden ein:");
            TotalEpisodes = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe die gesamte Minutenanzahl des Arcs ein:");
            TotalMinutes = int.Parse(Console.ReadLine());
            
            Console.Write("Gebe an wie viel vom Anime der Arc in Anspruch nimmt:");
            AnimePercent = Console.ReadLine();

            Database database = new Database();
            database.Connect();
            database.InsertData(Arc, StartonChapter, TotalChapters, TotalPages, MangaPercent, StartonEpisode, TotalEpisodes, TotalMinutes, AnimePercent);
            database.DisplayAllDocuments();
        }
    }
}

