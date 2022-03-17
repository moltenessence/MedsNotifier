﻿using MedsNotifier.Data.CustomModelAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.Models
{
    [BsonCollectionAttribute("refresh_tokens")]
    public class RefreshToken
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsUsed { get; set; }
    }
}
