using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OG.Domain.DTOs;
using OG.Domain.Types;
using OG.Domain.ViewModels;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OG.Services
{
    public class BidService: IBidService
    {

        public Response<BidResponseDTO> Get(BidRequestViewModel bid)
        {
            //using var client = new HttpClient();

            //client.BaseAddress = new Uri("https://www.myofficeguy.com/api/accounting/documents/create/");

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

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
                        new JProperty("CompanyID", bid.CompanyID),
                        new JProperty("APIKey", bid.APIKey)
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

            // var respose = new Response<BidResponseDTO>();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<Response<BidResponseDTO>>(json);
            }
        }
    }
}
