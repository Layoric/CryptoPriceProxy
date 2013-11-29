using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using CryptoPriceProxy.ResponseTypes;
using ServiceStack.Common.Web;
using ServiceStack.ServiceClient.Web;

namespace CryptoPriceProxy.Clients
{
    /// <summary>
    /// Bitcoin price client, default data comes from public MtGox API in USD
    /// http://data.mtgox.com/api/1/BTCUSD/ticker
    /// </summary>
    public class BitcoinPriceClient : ICoinPriceClient
    {
        readonly JsonServiceClient client = new JsonServiceClient("http://data.mtgox.com");

        public CoinPrice GetLatest()
        {
            CoinPrice result;
            MtGoxDto dto;

            try
            {
                dto = client.Get<MtGoxDto>("/api/1/BTCUSD/ticker");
            }
            catch (Exception e)
            {
                throw new HttpError("Failed to get latest price", e);
            }

            if (dto == null)
            {
                throw new Exception("HTTP server responded without any data");
            }
            try
            {
                result = dto.Response.ToCoinPrice();
            }
            catch (Exception e)
            {
                throw new SerializationException("Failed to serialize to 'CoinPrice'", e);
            }
            return result;
        }
    }
}
