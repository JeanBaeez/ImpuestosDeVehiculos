using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ResourceAPI.Models;

namespace ResourceAPI.Controllers
{
    [Route("api/TasaDollar")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        HttpClient http = new HttpClient();
         private string _address = "http://apilayer.net/api/live?access_key=f6c6f1decd4f4506e1f843264c3c9be5&currencies=DOP&source=USD&format=1";


        [HttpGet]
        [Route("/Dollar")]
        public async Task<string> getDollar()
        {


            HttpResponseMessage response = await http.GetAsync(_address);
            response.EnsureSuccessStatusCode();
            var result= await response.Content.ReadAsStringAsync();
           var t =  JsonConvert.DeserializeObject<APIStructure>(result);
            var y = t.quotes;
            return result;

        }



    }
}