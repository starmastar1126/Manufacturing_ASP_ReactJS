using EzyFindMobileApi.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace EzyFindMobileApi.General
{
    public class Utils
    {
        
        public static async Task<String> GetSMSToken()
        {
            IActionResult result;
            //var result;
            HttpClient client = new HttpClient();
            //string _tokenUpdated = "TOKEN";

            var TARGETURL = "https://rest.smsportal.com/v1/Authentication";
            // Update port # in the following line.
            client.BaseAddress = new Uri(TARGETURL);
            client.DefaultRequestHeaders.Accept.Clear();
            IConfigurationRoot configuration = GetConfig();
            string strUserName = configuration.GetSection("Keys").GetSection("MobileSmsAPI_UserName").Value;
            string strPassword = configuration.GetSection("Keys").GetSection("MobileSmsAPI_Password").Value;
            var byteArray = Encoding.ASCII.GetBytes(strUserName + ":" + strPassword);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(TARGETURL.ToString());
            if (response.IsSuccessStatusCode)
            {

                string responseString = response.Content.ReadAsStringAsync().Result;
                return responseString;            

            }
            return "";               

        }

        public static async Task SendSMSAsync(string p_strContactNo, int p_intUserID, string p_strMobileActivationCode)
        {
            

            HttpClient client = new HttpClient();
            var _tokenUpdated = await GetSMSToken();

            JsonTokenResponseSMS resultToken = JsonConvert.DeserializeObject<JsonTokenResponseSMS>(_tokenUpdated);


            // Update port # in the following line.
            client.BaseAddress = new Uri("https://rest.smsportal.com/v1/BulkMessages");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", resultToken.token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<SendSMSMessage> messages = new List<SendSMSMessage>();
            SendSMSMessage message = new SendSMSMessage();
            message.Content = "Your EzyFind OTP is " + p_strMobileActivationCode;
            message.Destination = p_strContactNo;
            messages.Add(message);
            SMSmessage sMSmessage = new SMSmessage();
            sMSmessage.Messages = messages;

            HttpResponseMessage response = await client.GetAsync(JsonConvert.SerializeObject(sMSmessage));
            if (response.IsSuccessStatusCode)
            {
               var result = await response.Content.ReadAsHttpResponseMessageAsync();
            }
         
        }
    

        public static IConfigurationRoot GetConfig()
        {
            string projectpath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).ToString();
            string currentdir = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

            return configuration;
        }
        public static void SendPasswordSMS(string p_strContactNo, int p_intUserID, string p_strMobileActivationCode, string p_strPassword)
        {
            //APISoapClient objMobileAPI = null;

            //IConfigurationRoot configuration = GetConfig();

            //string strUserName = configuration.GetSection("Keys").GetSection("MobileSmsAPI_UserName").Value;
            //string strPassword = configuration.GetSection("Keys").GetSection("MobileSmsAPI_Password").Value;
            
            //StringBuilder strMobileVerficationData = new StringBuilder();
            //StringBuilder strMobileVerficationOutput = new StringBuilder();

            //strMobileVerficationData.Append("<senddata>");
            //strMobileVerficationData.Append("<settings>");
            //strMobileVerficationData.Append("<return_credits>false</return_credits>");
            //strMobileVerficationData.Append("<return_entries_success_status>True</return_entries_success_status>");
            //strMobileVerficationData.Append("<return_entries_failed_status>True</return_entries_failed_status>");
            //strMobileVerficationData.Append("<default_date>"); strMobileVerficationData.Append(DateTime.Now.ToString("dd/MMM/yyyy")); strMobileVerficationData.Append("</default_date>");
            //strMobileVerficationData.Append("<default_time>"); strMobileVerficationData.Append(DateTime.Now.ToString("HH:mm")); strMobileVerficationData.Append("</default_time>");
            //strMobileVerficationData.Append("</settings>");
            //strMobileVerficationData.Append("<entries>");
            //strMobileVerficationData.Append("<numto>"); strMobileVerficationData.Append(p_strContactNo); strMobileVerficationData.Append("</numto>");
            //strMobileVerficationData.Append("<customerid>"); strMobileVerficationData.Append(p_intUserID); strMobileVerficationData.Append("</customerid>");
            //strMobileVerficationData.Append("<data1> Your EzyFind Password is "); strMobileVerficationData.Append(p_strPassword); strMobileVerficationData.Append("||www.ezyfind.co.za</data1>");
            //strMobileVerficationData.Append("</entries>");
            //strMobileVerficationData.Append("</senddata>");

            //using (objMobileAPI = new APISoapClient())
            //{
            //    try
            //    {
            //        strMobileVerficationOutput.Append(objMobileAPI.Send_STR_STR(strUserName, strPassword, strMobileVerficationData.ToString()));
            //    }
            //    catch (Exception Ex)
            //    {
            //        Elmah_SignalException(Ex, HttpContext.Current, "Sending SMS");
            //    }
            //}
        }

        public static void ElmahErrorCapture(ElmahError elmahError)
        {
            
            
        }

        public static string[] GoogleGeoCode(string address)
        {
            string[] strReturnVal = new string[2];
            string url = "https://maps.googleapis.com/maps/api/geocode/json?sensor=true&address=";

            IConfigurationRoot configuration = GetConfig();
            string gecodingAPIKey = configuration.GetSection("Keys").GetSection("GecodingAPIKey").Value;         

            dynamic googleResults = new Uri(JValue.Parse(url + address.Replace(' ', '+') + "&location_type=ROOFTOP&result_type=street_address&key=" + gecodingAPIKey).ToString());

            foreach (var result in googleResults.results)
            {
                strReturnVal[0] = result.geometry.location.lat.ToString();
                strReturnVal[1] = result.geometry.location.lng.ToString();
            }

            return strReturnVal;
        }

        public static string[] GoogleReverseGeoCode(string latlng)
        {
            string[] strReturnVal = new string[4];
            string url = "https://maps.googleapis.com/maps/api/geocode/json?sensor=true&latlng=";

            IConfigurationRoot configuration = GetConfig();
            string gecodingAPIKey = configuration.GetSection("Keys").GetSection("GecodingAPIKey").Value;


            dynamic googleResults = new Uri(JValue.Parse(url + latlng + "&location_type=ROOFTOP&result_type=street_address&key=" + gecodingAPIKey).ToString());

            // dynamic googleResults = new Uri(url + latlng + "&location_type=ROOFTOP&result_type=street_address&key=" + System.Configuration.ConfigurationManager.AppSettings["GecodingAPIKey"]).GetDynamicJsonObject();

            foreach (var result in googleResults.results)
            {
                foreach (var vData in result.address_components)
                {
                    if (vData.types[0] == "locality")
                    {
                        //Suburb
                        strReturnVal[0] = vData.long_name;
                    }
                    else if (vData.types[0] == "administrative_area_level_2")
                    {
                        //City
                        strReturnVal[1] = vData.long_name;
                    }
                    else if (vData.types[0] == "administrative_area_level_1")
                    {
                        //Province
                        strReturnVal[2] = vData.long_name;
                    }
                    else if (vData.types[0] == "country")
                    {
                        //Country
                        strReturnVal[3] = vData.long_name;
                    }
                }
            }

            return strReturnVal;
        }

        public static int GenerateRandomNo()
        {
            //Generate random number without 0 - Zero (As the user cant identify the difference between 0 and O)
            var exclude = new HashSet<int>() { 0 };
            var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));
            var random = new Random();
            int mCode = random.Next(1, 9999 - exclude.Count);

            return mCode;
        }
        


    }
}


