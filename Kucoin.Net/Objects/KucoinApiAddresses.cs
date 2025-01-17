﻿namespace Kucoin.Net.Objects
{
    /// <summary>
    /// Kucoin API addresses
    /// </summary>
    public class KucoinApiAddresses
    {
        /// <summary>
        /// The address used by the KucoinClient for the SPOT API
        /// </summary>
        public string SpotAddress { get; set; } = string.Empty;

        /// <summary>
        /// The address used by the KucoinClient for the futures API
        /// </summary>
        public string FuturesAddress { get; set; } = string.Empty;

        /// <summary>
        /// The default addresses to connect to the kucoin.com API
        /// </summary>
        public static readonly KucoinApiAddresses Default = new KucoinApiAddresses
        {
            SpotAddress = "https://api.kucoin.com/api/",
            FuturesAddress = "https://api-futures.kucoin.com/api/",
        };

        /// <summary>
        /// The addresses to connect to the kucoin.com sandbox API
        /// </summary>
        public static readonly KucoinApiAddresses TestNet = new KucoinApiAddresses
        {
            SpotAddress = "https://openapi-sandbox.kucoin.com/api/",
            FuturesAddress = "https://api-sandbox-futures.kucoin.com/api/",
        };
    }
}
