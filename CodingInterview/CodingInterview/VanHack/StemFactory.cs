using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Linq;

namespace CodingInterview.VanHack
{
    class StemFactory
    {
        private const string uri = "https://raw.githubusercontent.com/dwyl/english-words/master/words_alpha.txt";
        //CORRECT
        //public async static void GetStems() {
        //    var client = new HttpClient();
        //    HttpResponseMessage response = await client.GetAsync(uri);

        //    var stream = response.Content.ReadAsStringAsync().Result;
        //    string[] results = stream.Split(new char[] { '\r' });
        //    List<string> data = results.Where(r => r.StartsWith(stem)).Select(r => r).ToList();
        //    var json = JsonSerializer.Serialize<List<string>>(data);
        //    return json;
        //}

        //real
        /*
         [Route("")]
    [ApiController]
    public class StemsController : Controller
    {
        private const string uri = "https://raw.githubusercontent.com/dwyl/english-words/master/words_alpha.txt";
    
        public StemsController()
        {
         
        }
        
         [HttpGet]
          public async Task<ActionResult<string>> Get(string stem){
              var client = new HttpClient();
              HttpResponseMessage response = await client.GetAsync(uri);
              
              var stream = response.Content.ReadAsStringAsync().Result;
              string[] results = stream.Split(new char[] { '\r' });
              List<string> data = results.Where(r => r.StartsWith(stem)).Select(r=>r).ToList(); 
            var json = JsonSerializer.Serialize<List<string>>(data);
            return json;
          }
    }
         */
    }
}
