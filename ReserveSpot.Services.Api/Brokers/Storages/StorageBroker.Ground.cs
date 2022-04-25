// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReserveSpot.Services.Api.Models.Grounds;

namespace ReserveSpot.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Ground> Grounds { get; set; }

        public async ValueTask<Ground> InsertGroundAsync(Ground ground)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Ground> entityEntry = await broker.Grounds.AddAsync(ground);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}