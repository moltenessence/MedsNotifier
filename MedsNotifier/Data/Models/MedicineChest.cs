using MedsNotifier.Data.CustomModelAttributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models
{
    [BsonCollectionAttribute("chests")]
    public class MedicineChest
    {
       [BsonId]
       public Guid Id { get; set; }
       public ICollection<MedsModel> Meds { get; set; }
    }
}
