using AspNetCore.Identity.MongoDbCore.Models;
using MedsNotifier.Data.CustomModelAttributes;
using MedsNotifier.Data.Models;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedsNotifier.Data
{
    [BsonCollectionAttribute("users")]
    [BsonIgnoreExtraElements]
    public class User
    {
        public Guid Id { get; set; } = new Guid();
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public int? Height { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<MedsModel> Meds { get; set; }

    }
}
