// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using ReserveSpot.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace ReserveSpot.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly ReserveSpotApiBroker reserveSpotApiBroker;

        public HomeApiTests(ReserveSpotApiBroker reserveSpotApiBroker) =>
            this.reserveSpotApiBroker = reserveSpotApiBroker;
    }
}
