﻿using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualHFT.UserSettings;

namespace MarketConnectors.Bitfinex.Model
{
    public class PlugInSettings : ISetting
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public List<string> Symbols { get; set; }
        public int DepthLevels { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
