// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.EntityFrameworkCore;
using ReserveSpot.Services.Api.Models.Grounds;

namespace ReserveSpot.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SetGroundReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ground>()
                .HasOne(ground => ground.CreatedByUser)
                .WithMany(user => user.CreatedGrounds)
                .HasForeignKey(ground => ground.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ground>()
                .HasOne(ground => ground.UpdatedByUser)
                .WithMany(user => user.UpdatedGrounds)
                .HasForeignKey(ground => ground.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}