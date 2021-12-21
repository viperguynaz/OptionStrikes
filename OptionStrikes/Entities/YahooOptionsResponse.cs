﻿using System.Text.Json.Serialization;

namespace OptionStrikes.Entities
{
    // YahooOptionsResponse myDeserializedClass = JsonConvert.DeserializeObject<YahooOptionsResponse>(myJsonResponse); 
    public class Quote
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("quoteType")]
        public string? QuoteType { get; set; }

        [JsonPropertyName("quoteSourceName")]
        public string? QuoteSourceName { get; set; }

        [JsonPropertyName("triggerable")]
        public bool Triggerable { get; set; }

        [JsonPropertyName("earningsTimestamp")]
        public int EarningsTimestamp { get; set; }

        [JsonPropertyName("earningsTimestampStart")]
        public int EarningsTimestampStart { get; set; }

        [JsonPropertyName("earningsTimestampEnd")]
        public int EarningsTimestampEnd { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public double TrailingAnnualDividendRate { get; set; }

        [JsonPropertyName("trailingPE")]
        public double TrailingPE { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public double TrailingAnnualDividendYield { get; set; }

        [JsonPropertyName("epsTrailingTwelveMonths")]
        public double EpsTrailingTwelveMonths { get; set; }

        [JsonPropertyName("epsForward")]
        public double EpsForward { get; set; }

        [JsonPropertyName("epsCurrentYear")]
        public double EpsCurrentYear { get; set; }

        [JsonPropertyName("priceEpsCurrentYear")]
        public double PriceEpsCurrentYear { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public long SharesOutstanding { get; set; }

        [JsonPropertyName("bookValue")]
        public double BookValue { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public double FiftyDayAverage { get; set; }

        [JsonPropertyName("fiftyDayAverageChange")]
        public double FiftyDayAverageChange { get; set; }

        [JsonPropertyName("fiftyDayAverageChangePercent")]
        public double FiftyDayAverageChangePercent { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public double TwoHundredDayAverage { get; set; }

        [JsonPropertyName("twoHundredDayAverageChange")]
        public double TwoHundredDayAverageChange { get; set; }

        [JsonPropertyName("twoHundredDayAverageChangePercent")]
        public double TwoHundredDayAverageChangePercent { get; set; }

        [JsonPropertyName("marketCap")]
        public long MarketCap { get; set; }

        [JsonPropertyName("forwardPE")]
        public double ForwardPE { get; set; }

        [JsonPropertyName("priceToBook")]
        public double PriceToBook { get; set; }

        [JsonPropertyName("sourceInterval")]
        public int SourceInterval { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public int ExchangeDataDelayedBy { get; set; }

        [JsonPropertyName("pageViewGrowthWeekly")]
        public double PageViewGrowthWeekly { get; set; }

        [JsonPropertyName("averageAnalystRating")]
        public string? AverageAnalystRating { get; set; }

        [JsonPropertyName("tradeable")]
        public bool Tradeable { get; set; }

        [JsonPropertyName("firstTradeDateMilliseconds")]
        public long FirstTradeDateMilliseconds { get; set; }

        [JsonPropertyName("priceHint")]
        public int PriceHint { get; set; }

        [JsonPropertyName("postMarketChangePercent")]
        public double PostMarketChangePercent { get; set; }

        [JsonPropertyName("postMarketTime")]
        public int PostMarketTime { get; set; }

        [JsonPropertyName("postMarketPrice")]
        public double PostMarketPrice { get; set; }

        [JsonPropertyName("postMarketChange")]
        public double PostMarketChange { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public double RegularMarketChange { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public double RegularMarketChangePercent { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public int RegularMarketTime { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public double RegularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public double RegularMarketDayHigh { get; set; }

        [JsonPropertyName("regularMarketDayRange")]
        public string? RegularMarketDayRange { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public double RegularMarketDayLow { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public int RegularMarketVolume { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public double RegularMarketPreviousClose { get; set; }

        [JsonPropertyName("bid")]
        public double Bid { get; set; }

        [JsonPropertyName("ask")]
        public double Ask { get; set; }

        [JsonPropertyName("bidSize")]
        public int BidSize { get; set; }

        [JsonPropertyName("askSize")]
        public int AskSize { get; set; }

        [JsonPropertyName("fullExchangeName")]
        public string? FullExchangeName { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string? FinancialCurrency { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public double RegularMarketOpen { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public int AverageDailyVolume3Month { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public int AverageDailyVolume10Day { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChange")]
        public double FiftyTwoWeekLowChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekLowChangePercent")]
        public double FiftyTwoWeekLowChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekRange")]
        public string? FiftyTwoWeekRange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChange")]
        public double FiftyTwoWeekHighChange { get; set; }

        [JsonPropertyName("fiftyTwoWeekHighChangePercent")]
        public double FiftyTwoWeekHighChangePercent { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public double FiftyTwoWeekLow { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public double FiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("dividendDate")]
        public int DividendDate { get; set; }

        [JsonPropertyName("shortName")]
        public string? ShortName { get; set; }

        [JsonPropertyName("exchange")]
        public string? Exchange { get; set; }

        [JsonPropertyName("longName")]
        public string? LongName { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string? MessageBoardId { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string? ExchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string? ExchangeTimezoneShortName { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public int GmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("market")]
        public string? Market { get; set; }

        [JsonPropertyName("esgPopulated")]
        public bool EsgPopulated { get; set; }

        [JsonPropertyName("marketState")]
        public string? MarketState { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
    }

    public class Call
    {
        [JsonPropertyName("contractSymbol")]
        public string? ContractSymbol { get; set; }

        [JsonPropertyName("strike")]
        public double Strike { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("lastPrice")]
        public double LastPrice { get; set; }

        [JsonPropertyName("change")]
        public double Change { get; set; }

        [JsonPropertyName("percentChange")]
        public double PercentChange { get; set; }

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("openInterest")]
        public int OpenInterest { get; set; }

        [JsonPropertyName("bid")]
        public double Bid { get; set; }

        [JsonPropertyName("ask")]
        public double Ask { get; set; }

        [JsonPropertyName("contractSize")]
        public string? ContractSize { get; set; }

        [JsonPropertyName("expiration")]
        public int Expiration { get; set; }

        [JsonPropertyName("lastTradeDate")]
        public int LastTradeDate { get; set; }

        [JsonPropertyName("impliedVolatility")]
        public double ImpliedVolatility { get; set; }

        [JsonPropertyName("inTheMoney")]
        public bool InTheMoney { get; set; }
    }

    public class Put
    {
        [JsonPropertyName("contractSymbol")]
        public string? ContractSymbol { get; set; }

        [JsonPropertyName("strike")]
        public double Strike { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("lastPrice")]
        public double LastPrice { get; set; }

        [JsonPropertyName("change")]
        public double Change { get; set; }

        [JsonPropertyName("percentChange")]
        public double PercentChange { get; set; }

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("openInterest")]
        public int OpenInterest { get; set; }

        [JsonPropertyName("bid")]
        public double Bid { get; set; }

        [JsonPropertyName("ask")]
        public double Ask { get; set; }

        [JsonPropertyName("contractSize")]
        public string? ContractSize { get; set; }

        [JsonPropertyName("expiration")]
        public int Expiration { get; set; }

        [JsonPropertyName("lastTradeDate")]
        public int LastTradeDate { get; set; }

        [JsonPropertyName("impliedVolatility")]
        public double ImpliedVolatility { get; set; }

        [JsonPropertyName("inTheMoney")]
        public bool InTheMoney { get; set; }
    }

    public class Option
    {
        [JsonPropertyName("expirationDate")]
        public long ExpirationDate { get; set; }

        [JsonPropertyName("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonPropertyName("calls")]
        public List<Call>? Calls { get; set; }

        [JsonPropertyName("puts")]
        public List<Put>? Puts { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("underlyingSymbol")]
        public string? UnderlyingSymbol { get; set; }

        [JsonPropertyName("expirationDates")]
        public List<long>? ExpirationDates { get; set; }

        [JsonPropertyName("strikes")]
        public List<double>? Strikes { get; set; }

        [JsonPropertyName("hasMiniOptions")]
        public bool HasMiniOptions { get; set; }

        [JsonPropertyName("quote")]
        public Quote? Quote { get; set; }

        [JsonPropertyName("options")]
        public List<Option>? Options { get; set; }
    }

    public class OptionChain
    {
        [JsonPropertyName("result")]
        public List<Result>? Result { get; set; }

        [JsonPropertyName("error")]
        public object? Error { get; set; }

        public List<ExpirationOption>? OptionsChain
        {
            get
            {
                var options = new List<ExpirationOption>();

                if (Result?[0].Strikes != null)
                {
                    foreach (var strike in Result?[0].Strikes)
                    {
                        var call = Result?[0].Options?[0]?.Calls?.First<Call>(call => call.Strike == strike);
                        var put = Result?[0].Options?[0]?.Puts?.First<Put>(put => put.Strike == strike);
                        options.Add(new ExpirationOption
                        {
                            Strike = strike,
                            CallAsk = call?.Ask ?? 0,
                            CallBid = call?.Bid ?? 0,
                            CallChange = call?.Change ?? 0,
                            CallLastPrice = call?.LastPrice ?? 0,
                            CallOpenInterest = call?.OpenInterest ?? 0,
                            CallPercentChange = call?.PercentChange ?? 0,
                            CallVolume = call?.Volume ?? 0,
                            PutAsk = put?.Ask ?? 0,
                            PutBid = put?.Bid ?? 0,
                            PutChange = put?.Change ?? 0,
                            PutLastPrice = put?.LastPrice ?? 0,
                            PutOpenInterest = put?.OpenInterest ?? 0,
                            PutPercentChange = put?.PercentChange ?? 0,
                            PutVolume = put?.Volume ?? 0
                        }
                        );
                    }
                }

                return options;
            }

        }
    }

    public class YahooOptionsResponse
    {
        [JsonPropertyName("optionChain")]
        public OptionChain? OptionChain { get; set; }
    }

    public class ExpirationOption
    {
        public int CallVolume { get; set; }
        public int CallOpenInterest { get; set; }
        public double CallLastPrice { get; set; }
        public double CallChange { get; set; }
        public double CallPercentChange { get; set; }
        public double CallBid { get; set; }
        public double CallAsk { get; set; }
        public double Strike { get; set; }
        public int PutVolume { get; set; }
        public int PutOpenInterest { get; set; }
        public double PutLastPrice { get; set; }
        public double PutChange { get; set; }
        public double PutPercentChange { get; set; }
        public double PutBid { get; set; }
        public double PutAsk { get; set; }
    }

}
