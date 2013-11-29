using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoPriceProxy.ResponseTypes;

namespace CryptoPriceProxy
{
    public static class CryptoExtensions
    {
        public static CoinPrice ToCoinPrice(this MtGoxDtoResponse dto)
        {
            var result = new CoinPrice();
            result.High = decimal.Parse(dto.High.Value);
            result.Low = decimal.Parse(dto.Low.Value);
            result.Average = decimal.Parse(dto.Average.Value);
            result.Buy = decimal.Parse(dto.Buy.Value);
            result.Sell = decimal.Parse(dto.Sell.Value);
            result.LastTrade = decimal.Parse(dto.Last.Value);
            result.DisplayValue = dto.Last.DisplayShort;
            result.FromCurrencyCode = dto.Item;
            result.ToCurrencyCode = dto.Last.Currency;
            //HACK failed to parse dto.Now correctly
            result.UpdatDateTime = DateTime.UtcNow;
            result.Volume = decimal.Parse(dto.Volume.Value);
            return result;
        }
    }
}
