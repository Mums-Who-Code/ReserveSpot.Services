// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ReserveSpot.Services.Api.Models.Grounds;

namespace ReserveSpot.Services.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Ground> CreatedGrounds { get; set; }

        [JsonIgnore]
        public IEnumerable<Ground> UpdatedGrounds { get; set; }
    }
}