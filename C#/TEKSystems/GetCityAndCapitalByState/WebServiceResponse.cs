using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace GetCityAndCapitalByState
{
    public class WebServiceResponse
    {
        public string GetResponse(string requestUri)
        {
            string responseFromServer = null;
            HttpWebResponse response;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);
                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream);
                    responseFromServer = reader.ReadToEnd();
                }

                var status = response.StatusCode;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new WebException("There are some problems to retrieve content. Status code: " + status);
                }
            }
            catch (WebException ex)
            {
                responseFromServer = ex.Message;
            }
            return responseFromServer;
        }
    }
}