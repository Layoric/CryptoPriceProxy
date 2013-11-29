using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPriceProxy
{
    /// <summary>
    /// Standard interface for all crypto currently clients
    /// </summary>
    public interface ICoinPriceClient
    {
        /// <summary>
        /// Gets the latest value converted to the default CoinPrice model
        /// </summary>
        /// <returns></returns>
        CoinPrice GetLatest();
    }
}
