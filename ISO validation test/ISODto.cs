using System.Collections.Generic;

namespace ISO_validation_test
{
    public class IsoDto
    {
        public Country Country { get; set; }

    }

    public class Country
    {
        public Currency currency { get; set; }
        public Info info { get; set; }
        public List<string> languages { get; set; }
        public Phone phone { get; set; }
        public Postal postal { get; set; }
        public List<string> states { get; set; }
    }



    public class Postal
    {
        public string Description { get; set; }
        public string RedundantCharacters { get; set; }
        public string ValidationRegex { get; set; }
        public string charSet { get; set; }
        public List<string> postalLenghts { get; set; }
        public List<string> postalFormats { get; set; }
    }

    public class Phone
    {
        public string countryCode { get; set; }
        public List<string> mobile_begin_with { get; set; }
        public string phone_number_lengths { get; set; }
    }

    public class Info
    {
        public string shortName { get; set; }
        public string longName { get; set; }
        public string alpha2 { get; set; }
        public string alpha3 { get; set; }
        public string isoNumericCode { get; set; }
        public string ioc { get; set; }
        public string capitalCity { get; set; }
        public string tld { get; set; }
    }

    public class Currency
    {
        public List<string> currencyCode { get; set; }
        public List<string> currencyName { get; set; }
        public List<string> currencySymbol { get; set; }
    }
}