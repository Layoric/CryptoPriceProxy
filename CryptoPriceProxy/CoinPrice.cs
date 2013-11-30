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
        public double Low { get; set; }
        public double Average { get; set; }
        public double High { get; set; }
        public string DisplayValue { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public double LastTrade { get; set; }
        public DateTime UpdatDateTime { get; set; }
        public double Volume { get; set; }
    }
}
