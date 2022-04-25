// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using ReserveSpot.Services.Api.Models.Grounds;

namespace ReserveSpot.Services.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Ground> InsertGroundAsync(Ground ground);
    }
}