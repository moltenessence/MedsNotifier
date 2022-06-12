using MedsNotifier.Data.CustomModelAttributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MedsNotifier.Data.Models
{
    [BsonCollectionAttribute("meds")]
    [BsonIgnoreExtraElements]
    public class MedsModel
    {
        [BsonId]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; } = "None";
        [Required]
        public string Color { get; set; }
        [Required]
        public int TotalDosage { get; set; }
        [Required]
        [DosageAmountValidation]
        public int SingleDosage { get; set; }
        [Required]
        public int DosesPerDayAmount { get; set; }
        [Required]
        public MedsType MedsType { get; set; }
        public DateTime StartMedsDateTime { get; set; }
        [EnsureFinishCourseDateNotInPast]
        [Required]
        public DateTime FinishMedsDateTime { get; set; }
    }
}
