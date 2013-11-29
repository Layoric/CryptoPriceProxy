using System;
using CryptoPriceProxy;
using CryptoPriceProxy.Clients;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProxyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BitcoinPriceClientTest()
        {
            ICoinPriceClient client = new BitcoinPriceClient();
            var latest = client.GetLatest();
            Assert.IsTrue(latest != null && latest.FromCurrencyCode == "BTC");
        }
    }
}
