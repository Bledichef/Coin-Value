namespace Coin_Value.Models
{
    public class CryptoModel
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal? PriceChange24h { get; set; }
    }
}
