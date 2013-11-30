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
            result.High = double.Parse(dto.High.Value);
            result.Low = double.Parse(dto.Low.Value);
            result.Average = double.Parse(dto.Average.Value);
            result.Buy = double.Parse(dto.Buy.Value);
            result.Sell = double.Parse(dto.Sell.Value);
            result.LastTrade = double.Parse(dto.Last.Value);
            result.DisplayValue = dto.Last.DisplayShort;
            result.FromCurrencyCode = dto.Item;
            result.ToCurrencyCode = dto.Last.Currency;
            //HACK failed to parse dto.Now correctly
            result.UpdatDateTime = DateTime.UtcNow;
            result.Volume = double.Parse(dto.Volume.Value);
            return result;
        }

        public static CoinPrice ToCoinPrice(this BtcLiteCoinDtoResponse dto, string toCurrency)
        {
            var result = new CoinPrice();
            result.Average = dto.avg;
            result.Buy = dto.buy;
            result.DisplayValue = dto.last.ToString(); //TODO
            result.FromCurrencyCode = "LTC";
            result.ToCurrencyCode = toCurrency;
            result.High = dto.high;
            result.LastTrade = dto.last;
            result.Low = dto.low;
            result.Sell = dto.sell;
            result.UpdatDateTime = DateTime.Now;
            result.Volume = dto.vol;
            return result;
        }
    }
}
