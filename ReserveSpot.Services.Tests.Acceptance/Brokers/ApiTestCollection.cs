// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Xunit;

namespace ReserveSpot.Services.Tests.Acceptance.Brokers
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection : ICollectionFixture<ReserveSpotApiBroker>
    {
    }
}
