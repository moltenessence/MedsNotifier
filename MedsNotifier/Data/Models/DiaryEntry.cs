using MedsNotifier.Data.CustomModelAttributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models
{
    [BsonIgnoreExtraElements]
    public class DiaryEntry
    {
        [BsonId]
        public Guid Id { get; set; } = new Guid();
        public string MedicineName { get; set; }
        public DateTime DateMedicineTaken { get; set; }
    }
}
