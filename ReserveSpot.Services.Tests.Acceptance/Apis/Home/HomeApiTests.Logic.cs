// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace ReserveSpot.Services.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTests
    {
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            //given
            string expectedHomeMessage =
                 "Hurry Up! Reserve Your Spot. We are happy to see you playing sports.";

            //when
            string actualHomeMessage =
                 await this.reserveSpotApiBroker.GetHomeMessageAsync();

            //then
            actualHomeMessage.Should().BeEquivalentTo(expectedHomeMessage);
        }
    }
}
