// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;

namespace ReserveSpot.Services.Api.Brokers.DateTime
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() =>
            DateTimeOffset.UtcNow;
    }
}
