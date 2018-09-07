using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PeopleSearch.Entities
{
    public class People
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("hobby")]
        public string Hobby { get; set; }
    }
}