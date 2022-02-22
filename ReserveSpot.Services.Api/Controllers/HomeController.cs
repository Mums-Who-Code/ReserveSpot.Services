// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ReserveSpot.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> get() =>
            Ok("Hurry Up! Reserve Your Spot. We are happy to see you playing sports.");
    }
}
