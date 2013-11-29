using System.Runtime.Serialization;

namespace CryptoPriceProxy.ResponseTypes
{
    [DataContract]
    public class MtGoxDtoResponse
    {
        [DataMember(Name = "high")]
        public MtGoxPriceSample High { get; set; }
        [DataMember(Name = "low")]
        public MtGoxPriceSample Low { get; set; }
        [DataMember(Name = "avg")]
        public MtGoxPriceSample Average { get; set; }
        [DataMember(Name = "vwap")]
        public MtGoxPriceSample VolumeWeightedAveragePrice { get; set; }
        [DataMember(Name = "vol")]
        public MtGoxPriceSample Volume { get; set; }
        [DataMember(Name = "last_local")]
        public MtGoxPriceSample LastLocal { get; set; }
        [DataMember(Name = "last_orig")]
        public MtGoxPriceSample LastOrigin { get; set; }
        [DataMember(Name = "last_all")]
        public MtGoxPriceSample LastAll { get; set; }
        [DataMember(Name = "last")]
        public MtGoxPriceSample Last { get; set; }
        [DataMember(Name = "buy")]
        public MtGoxPriceSample Buy { get; set; }
        [DataMember(Name = "sell")]
        public MtGoxPriceSample Sell { get; set; }
        [DataMember(Name = "item")]
        public string Item { get; set; }
        [DataMember(Name = "now")]
        public string Now { get; set; }
    }

    [DataContract]
    public class MtGoxDto
    {
        [DataMember(Name = "result")]
        public string Result { get; set; }
        [DataMember(Name = "return")]
        public MtGoxDtoResponse Response  { get; set; }
    }

    [DataContract]
    public class MtGoxPriceSample
    {
        [DataMember(Name = "value")]
        public string Value { get; set; }
        [DataMember(Name = "value_int")]
        public string ValueInt { get; set; }
        [DataMember(Name = "display")]
        public string Display { get; set; }
        [DataMember(Name = "display_short")]
        public string DisplayShort { get; set; }
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
    } 
}
