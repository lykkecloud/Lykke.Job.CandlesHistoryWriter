﻿// Copyright (c) 2019 Lykke Corp.
// See the LICENSE file in the project root for more information.

using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.CandlesHistoryWriter.Services.Settings
{
    public class RabbitSettings
    {
        public RabbitEndpointSettings CandlesSubscription { get; set; }
        [Optional]
        public ushort? Prefetch { get; set; }
    }
}
