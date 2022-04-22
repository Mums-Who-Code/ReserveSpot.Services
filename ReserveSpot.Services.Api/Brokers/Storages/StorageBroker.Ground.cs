// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.EntityFrameworkCore;
using ReserveSpot.Services.Api.Models.Grounds;

namespace ReserveSpot.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Ground> Grounds { get; set; }
    }
}