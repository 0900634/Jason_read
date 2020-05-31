using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Json_read
{
    class Program
    { 
        static void Main(string[] args)
        {
            using (var webClient = new WebClient())
            {
               string rawJason = webClient.DownloadString("http://finfo-api.vndirect.com.vn/v3/stocks/derivatives?derTypes=CW&statuses=LISTED");
                CQCollection cqCollection = JsonConvert.DeserializeObject<CQCollection>(rawJason);
                Console.WriteLine(cqCollection.Cq.Count);
                Console.ReadLine();
            }

        }
    }
}
