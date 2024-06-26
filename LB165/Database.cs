using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB;

public class Database
{
    private IMongoCollection<BsonDocument> collection;

    public void Connect()
    {
        MongoClient dbClient = new MongoClient("mongodb://UserAdmin:123456789@localhost:27017/");
        var database = dbClient.GetDatabase("LB165");
        collection = database.GetCollection<BsonDocument>("OnePieceArcs");
    }

    public void InsertData(string Arc, int StartonChapter, int TotalChapters, int TotalPages, string MangaPercent, int StartonEpisode, int TotalEpisodes, int TotalMinutes, string AnimePercent)
    {
        var document = new BsonDocument
        {
            { "Arc", Arc },
            { "StartonChapter", StartonChapter },
            { "TotalChapters", TotalChapters },
            { "TotalPages", TotalPages },
            { "MangaPercent", MangaPercent },
            { "StartonEpisode", StartonEpisode },
            { "TotalEpisodes", TotalEpisodes },
            { "TotalMinutes", TotalMinutes },
            { "AnimePercent", AnimePercent }
        };
        collection.InsertOne(document);
        Console.WriteLine("Document inserted successfully.");
    }

    public void DisplayAllDocuments()
    {
        var documents = collection.Find(new BsonDocument()).ToList();
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }

    public void UpdateData(string Arc, int StartonChapter, int TotalChapters, int TotalPages, string MangaPercent, int StartonEpisode, int TotalEpisodes, int TotalMinutes, string AnimePercent)
    {
        var filter = Builders<BsonDocument>.Filter.Eq("Arc", Arc);
        var update = Builders<BsonDocument>.Update
            .Set("StartonChapter", StartonChapter)
            .Set("TotalChapters", TotalChapters)
            .Set("TotalPages", TotalPages)
            .Set("MangaPercent", MangaPercent)
            .Set("StartonEpisode", StartonEpisode)
            .Set("TotalEpisodes", TotalEpisodes)
            .Set("TotalMinutes", TotalMinutes)
            .Set("AnimePercent", AnimePercent);

        var result = collection.UpdateOne(filter, update);
        Console.WriteLine($"Document updated: {result.ModifiedCount} document(s) modified.");
    }

    public void DeleteData(string Arc)
    {
        var filter = Builders<BsonDocument>.Filter.Eq("Arc", Arc);
        var result = collection.DeleteOne(filter);
        Console.WriteLine($"Document deleted: {result.DeletedCount} document(s) deleted.");
    }
}




