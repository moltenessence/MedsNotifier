using MedsNotifier.Data.CustomModelAttributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models
{
    [BsonCollectionAttribute("meds")]
    public class MedsModel
    {
        [BsonId]
        public Guid Id { get; } = new Guid();
        [BsonRequired]
        public string Name { get; set; }
        public string Description { get; set; }
        [BsonRequired]
        public Color Color { get; set; }
        [BsonRequired]
        public int TotalDosage { get; set; }
        [BsonRequired]
        public int SingleDosage { get; set; }
        [BsonRequired]
        public int DosesPerDayAmount { get; set; }
        public MedsType? MedsType { get; set; }
        public DateTime StartMedsDateTime { get; set; }
        public DateTime FinishMedsDateTime { get; set; }
    }
}
