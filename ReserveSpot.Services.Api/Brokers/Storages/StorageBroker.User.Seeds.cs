// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using Microsoft.EntityFrameworkCore;
using ReserveSpot.Services.Api.Models.Users;

namespace ReserveSpot.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var serviceAdminUser = new User
            {
                //Id = Guid.Parse("80aea9ae-967a-4718-b04e-97d2614b862b")
                Id = Guid.Parse("4c54b038-c653-4904-a33f-54e60ca4d531"),
                Name = "Admin"
            };

            modelBuilder.Entity<User>().HasData(serviceAdminUser);

        }
    }
}
