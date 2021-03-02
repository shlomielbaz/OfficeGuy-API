using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OG.Domain.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        // GET: api/<BidController>
        [HttpGet]
        public string GetAsync(BidRequestDTO bid)
        {

            using var client = new HttpClient();

            client.BaseAddress = new Uri("https://www.myofficeguy.com/api/accounting/documents/create/");
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            JObject requstData = new JObject(
                new JProperty("Details",
                    new JObject(
                        new JProperty("Customer",
                            new JObject(
                                new JProperty("Name", bid.CustomerName)
                            )
                        )
                    )
                ),
                new JProperty("Credentials",
                    new JObject(
                        new JProperty("CompanyID", 112355),
                        new JProperty("APIKey", "AWrQx04WMUEpc3VKmhOmHJ4p9Fy0npMTfem2SmqtvjekdKLQqk")
                    )
                ),
                new JProperty("Items",
                    new JArray(
                        new JObject(
                            new JProperty("Quantity", 1),
                            new JProperty("UnitPrice", bid.UnitPrice),
                            new JProperty("TotalPrice", bid.UnitPrice),
                            new JProperty("Item",
                                new JObject(
                                    new JProperty("Name", bid.ItemName)
                                )
                            )
                        )
                    )
                )
            );


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.myofficeguy.com/api/accounting/documents/create/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                streamWriter.Write(requstData.ToString());
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
               return streamReader.ReadToEnd();
            }










            ////var url = "repos/symfony/symfony/contributors";
            //HttpResponseMessage response = await client.GetAsync("https://www.myofficeguy.com/api/accounting/documents/create/");
            //response.EnsureSuccessStatusCode();
            //var resp = await response.Content.ReadAsStringAsync();

            ////List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(resp);
            ////contributors.ForEach(Console.WriteLine);

            ////record Contributor(string Login, short Contributions);



            //return result;
        }

        // GET api/<BidController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BidController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BidController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BidController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
