// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;

namespace ReserveSpot.Services.Tests.Acceptance.Brokers
{
    public partial class ReserveSpotApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMessageAsync() =>
            await this.apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}
