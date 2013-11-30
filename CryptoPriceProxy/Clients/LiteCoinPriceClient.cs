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
    public class LiteCoinPriceClient : ICoinPriceClient
    {
        readonly JsonServiceClient client = new JsonServiceClient("https://btc-e.com");

        public CoinPrice GetLatest()
        {
            CoinPrice result;
            BtcLiteCoinDto dto;

            try
            {
                dto = client.Get<BtcLiteCoinDto>("/api/2/ltc_usd/ticker");
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
                result = dto.ticker.ToCoinPrice("USD");
            }
            catch (Exception e)
            {
                throw new SerializationException("Failed to serialize to 'CoinPrice'", e);
            }
            return result;
        }
    }
}
