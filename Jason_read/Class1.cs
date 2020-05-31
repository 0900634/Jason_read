using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_read
{
          public class CQ
        {
            public string currencyCode { get; set; }
            public string cwType { get; set; }
            public string derCode { get; set; }
            public string derName { get; set; }
            public string derType { get; set; }
            public string deriLegalName { get; set; }
            public string exchangeCode { get; set; }
            public string exerciseType { get; set; }
            public string expiredMonth { get; set; }
            public DateTime expiryDate { get; set; }
            public object finalSettlementDate { get; set; }
            public DateTime firstTradingDate { get; set; }
            public string id { get; set; }
            public string isin { get; set; }
            public string issuer { get; set; }
            public string issuerName { get; set; }
            public DateTime lastTradingDate { get; set; }
            public int listedQtty { get; set; }
            public string locale { get; set; }
            public object multiplier { get; set; }
            public string paymentMethod { get; set; }
            public string paymentMethodNonVn { get; set; }
            public int period { get; set; }
            public object positionLimit { get; set; }
            public string status { get; set; }
            public string underlyingAsset { get; set; }
            public string underlyingType { get; set; }
            public int unit { get; set; }
            public object valuationMethod { get; set; }
        }
}
