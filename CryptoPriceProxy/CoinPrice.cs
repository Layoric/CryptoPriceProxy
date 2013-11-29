using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Common;
using ServiceStack.Common.Web;
using ServiceStack.ServiceClient.Web;
using ServiceStack.Text;

namespace CryptoPriceProxy
{
    public class CoinPrice
    {
        public string ToCurrencyCode { get; set; }
        public string FromCurrencyCode { get; set; }
        public decimal Low { get; set; }
        public decimal Average { get; set; }
        public decimal High { get; set; }
        public string DisplayValue { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public decimal LastTrade { get; set; }
        public DateTime UpdatDateTime { get; set; }
        public decimal Volume { get; set; }
    }
}
