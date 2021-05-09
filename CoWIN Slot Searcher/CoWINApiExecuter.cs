using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;


namespace CoWIN_Slot_Searcher
{
    public static class CoWINApiExecuter
    {
        /// <summary>
        /// Represents cowin portal uri
        /// </summary>
        const string cowinUri = "https://cdn-api.co-vin.in/";

        /// <summary>
        /// API path for getting slot details
        /// </summary>
        const string apiPathForSlotDetails = "api/v2/appointment/sessions/public/calendarByDistrict?district_id={0}&date={1}";

        /// <summary>
        /// API path for getting state details
        /// </summary>
        const string apiPathForStateDetails = "api/v2/admin/location/states";


        /// <summary>
        /// API path for getting district details
        /// </summary>
        const string apiPathForDistrictDetails = "api/v2/admin/location/districts/{0}";

        /// <summary>
        /// Gets the slot details of a city
        /// </summary>
        /// <param name="distId">Id of specific distric</param>
        /// <param name="date">Search date</param>
        /// <returns></returns>
        public static SlotDetails GetSlotDetails(string distId, string date)
        {
            SlotDetails slotDetails = null;

            if (!string.IsNullOrEmpty(distId) && !string.IsNullOrEmpty(date))
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(cowinUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Prepare the path
                string apiPath = string.Format(apiPathForSlotDetails, distId, date);

                //Get the response
                HttpResponseMessage response = client.GetAsync(apiPath).Result;
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = response.Content.ReadAsStringAsync().Result;
                    var serializer = new JavaScriptSerializer();
                    slotDetails = serializer.Deserialize<SlotDetails>(jsonResult);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return slotDetails;
        }

        public static StateDetails GetStateDetails()
        {
            StateDetails stateDetails = null;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(cowinUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Get the response
            HttpResponseMessage response = client.GetAsync(apiPathForStateDetails).Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                var serializer = new JavaScriptSerializer();
                stateDetails = serializer.Deserialize<StateDetails>(jsonResult);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
            return stateDetails;
        }

        public static DistrictDetails GetDistrictDetails(string stateID)
        {
            DistrictDetails districtDetails = null;

            if (!string.IsNullOrEmpty(stateID))
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(cowinUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Prepare the path
                string apiPath = string.Format(apiPathForDistrictDetails, stateID);

                //Get the response
                HttpResponseMessage response = client.GetAsync(apiPath).Result;
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = response.Content.ReadAsStringAsync().Result;
                    var serializer = new JavaScriptSerializer();
                    districtDetails = serializer.Deserialize<DistrictDetails>(jsonResult);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return districtDetails;
        }
    }
}
