using System;
using MongoDB.Bson;

namespace MongoDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.Connect();

            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("\n=== Menü ===");
                Console.WriteLine("1. Daten einfügen");
                Console.WriteLine("2. Daten aktualisieren");
                Console.WriteLine("3. Daten löschen");
                Console.WriteLine("4. Alle Dokumente anzeigen");
                Console.WriteLine("5. Beenden");
                Console.Write("Wähle eine Option (1-5): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        InsertData(database);
                        break;
                    case "2":
                        UpdateData(database);
                        break;
                    case "3":
                        DeleteData(database);
                        break;
                    case "4":
                        database.DisplayAllDocuments();
                        break;
                    case "5":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Zahl von 1 bis 5.");
                        break;
                }
            }
        }

        static void InsertData(Database database)
        {
            Console.WriteLine("\n=== Daten einfügen ===");
            Console.Write("Gebe den Namen des Arcs ein: ");
            string Arc = Console.ReadLine();
            Console.Write("Gebe das 1. Chapter des Mangas ein: ");
            int StartonChapter = int.Parse(Console.ReadLine());
            Console.Write("Gebe die Anzahl Chapters ein: ");
            int TotalChapters = int.Parse(Console.ReadLine());
            Console.Write("Gebe die gesamte Seitenanzahl des Arcs ein: ");
            int TotalPages = int.Parse(Console.ReadLine());
            Console.Write("Gebe an wie viel vom Manga der Arc in Anspruch nimmt: ");
            string MangaPercent = Console.ReadLine();
            Console.Write("Gebe das 1. Episode des Animes ein: ");
            int StartonEpisode = int.Parse(Console.ReadLine());
            Console.Write("Gebe die Anzahl Episoden ein: ");
            int TotalEpisodes = int.Parse(Console.ReadLine());
            Console.Write("Gebe die gesamte Minutenanzahl des Arcs ein: ");
            int TotalMinutes = int.Parse(Console.ReadLine());
            Console.Write("Gebe an wie viel vom Anime der Arc in Anspruch nimmt: ");
            string AnimePercent = Console.ReadLine();

            database.InsertData(Arc, StartonChapter, TotalChapters, TotalPages, MangaPercent, StartonEpisode, TotalEpisodes, TotalMinutes, AnimePercent);
        }

        static void UpdateData(Database database)
        {
            Console.WriteLine("\n=== Daten aktualisieren ===");
            Console.Write("Gebe den Namen des Arcs ein, den du aktualisieren möchtest: ");
            string ArcToUpdate = Console.ReadLine();
            Console.Write("Gebe das neue 1. Chapter des Mangas ein: ");
            int NewStartonChapter = int.Parse(Console.ReadLine());
            Console.Write("Gebe die neue Anzahl Chapters ein: ");
            int NewTotalChapters = int.Parse(Console.ReadLine());
            Console.Write("Gebe die gesamte Seitenanzahl des Arcs ein: ");
            int TotalPages = int.Parse(Console.ReadLine());
            Console.Write("Gebe an wie viel vom Manga der Arc in Anspruch nimmt: ");
            string MangaPercent = Console.ReadLine();
            Console.Write("Gebe das 1. Episode des Animes ein: ");
            int StartonEpisode = int.Parse(Console.ReadLine());
            Console.Write("Gebe die Anzahl Episoden ein: ");
            int TotalEpisodes = int.Parse(Console.ReadLine());
            Console.Write("Gebe die gesamte Minutenanzahl des Arcs ein: ");
            int TotalMinutes = int.Parse(Console.ReadLine());
            Console.Write("Gebe an wie viel vom Anime der Arc in Anspruch nimmt: ");
            string AnimePercent = Console.ReadLine();

            database.UpdateData(ArcToUpdate, NewStartonChapter, NewTotalChapters, TotalPages, MangaPercent, StartonEpisode, TotalEpisodes, TotalMinutes, AnimePercent);
        }

        static void DeleteData(Database database)
        {
            Console.WriteLine("\n=== Daten löschen ===");
            Console.Write("Gebe den Namen des Arcs ein, den du löschen möchtest: ");
            string ArcToDelete = Console.ReadLine();
            database.DeleteData(ArcToDelete);
        }
    }
}

