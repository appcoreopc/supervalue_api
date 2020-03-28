using System.Collections.Generic;

namespace SuperValueAPI.Controllers
{
    public class LocationModel
    {
        public float Lat { get; set; }

        public float Long { get; set; }

        public string ProductToLookFor { get; set; }
    }

    public class GeoLocationQueryModel
    {

        public float Lat { get; set; }

        public float Long { get; set; }

        public string ProductToLookFor { get; set; }

        public int Start { get; set; }
    }


    public class ProductQueryModel
    {

        public float Lat { get; set; }

        public float Long { get; set; }

        public string ProductToLookFor { get; set; }

         public int Start { get; set; }
    }


    public class PaymentIntentModel
    {
        public IEnumerable<ProductInfo> ProductInfo { get; set;  }

        public long? Amount { get; set; }

        public string CustomerId { get; set; }

        public string Currency { get; set; }
       
    }

}