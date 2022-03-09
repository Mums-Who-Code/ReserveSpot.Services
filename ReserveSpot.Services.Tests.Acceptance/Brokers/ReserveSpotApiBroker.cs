// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using ReserveSpot.Services.Api;
using RESTFulSense.Clients;

namespace ReserveSpot.Services.Tests.Acceptance.Brokers
{
    public partial class ReserveSpotApiBroker
    {
        private readonly WebApplicationFactory<Startup> webApplicationFactory;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public ReserveSpotApiBroker()
        {
            this.webApplicationFactory = new WebApplicationFactory<Startup>();
            this.httpClient = this.webApplicationFactory.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
