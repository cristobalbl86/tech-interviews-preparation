using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Data;
using Nancy.Json;
using Newtonsoft.Json;

namespace CodingInterview.VanHack
{
    class Transactions
    {
        /*
 * Complete the 'totalTransactions' function below.
 *
 * The function is expected to return a 2D_INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER locationId
 *  2. STRING transactionType
 */
        //public DataTable dt { get; set; }
        public static List<List<int>> totalTransactions(int locationId, string transactionType)
        {

            GetRequest(locationId, transactionType);
            return null;
        }

        public class ResponseResult {
            public string Page { get; set; }
            public int PerPage { get; set; }
            public int Total { get; set; }
            public int TotalPages { get; set; }
            public List<Data> Data { get; set; }
        }

        public class Location {
            public int id { get; set; }
            public string address { get; set; }
            public string cit { get; set; }
            public string zipCode { get; set; }
        }

        public class Data {
            public int id { get; set; }
            public DateTime timestamp { get; set; }
            public int userId { get; set; }
            public string userName { get; set; }
            public string txnType { get; set; }
            public string amount { get; set; }
            public Location location { get; set; }
            public string ip { get; set; }
        }

        public static async void GetRequest(int locationid, string trxType) {
            string url = $"https://jsonmock.hackerrank.com/";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                //var response = client.GetAsync("data");
                //response.Wait();

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                    );

                HttpResponseMessage response = await client.GetAsync($"api/transactions/search?txnType={trxType}&page=1");

                //var result = response.Result;
                List<Data> datainfo = new List<Data>();
                ResponseResult myres = new ResponseResult();

                if (response.IsSuccessStatusCode)
                {
                    //List<Data> final = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(await response.Content.ReadAsStringAsync());
                    var readResult = response.Content.ReadAsStringAsync().Result;
                    //readResult.Wait();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(redResult);
                    myres = JsonConvert.DeserializeObject<ResponseResult>(readResult);
                    //var data = await response.Content.ReadAsStringAsync();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(data);

                    //string data = response.Content.ReadAsStringAsync();
                    //use JavaScriptSerializer from System.Web.Script.Serialization
                    //JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    //products = JSserializer.Deserialize<List<Product>>(data);
                }

            }
        }
    }
}

