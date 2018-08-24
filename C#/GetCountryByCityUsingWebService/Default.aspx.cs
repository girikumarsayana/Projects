using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace GetCountryByCityUsingWebService
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            Label1.Visible = false;
        }

        private void GetCities()
        {
            //ensuring whether the country Name is not empty  
            if (EnterCity.Text == " " || EnterCity.Text == null)
            {
                Label1.Visible = true;
                Label1.Text = "Please Enter Country Name";
            }
            else
            {
                ResultTextBox.Text = CityStateLookupRequest(EnterCity.Text.Trim());
            }
        }
        public string GetResponse(string requestUri)
        {
            string responseFromServer = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);

                //WebProxy proxyRequest = new WebProxy("0.0.0.0", 8080);
                //proxyRequest.BypassProxyOnLocal = false;
                //request.Proxy = proxyRequest;
                //request.Credentials = new NetworkCredential("****", "*****");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream);
                    responseFromServer = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                ErrorLabel.Text = ex.Message;
            } 
            return responseFromServer;
        }

        public string CityStateLookupRequest(string CityName)
        {            
            string state = null;
            string requestUri = "https://maps.googleapis.com/maps/api/geocode/json?address=+City+"+CityName+"&key=AIzaSyDGZ0aeC7ymO2Rir8DdZJajPI1oMNyI4BQ&sensor=true&key=SERVERKEY";

            string responseFromServer = GetResponse(requestUri);

            try
            {
                Data data = JsonConvert.DeserializeObject<Data>(responseFromServer);
                if (data.results.Count != 0)
                {
                    foreach (Result result in data.results)
                    {
                        foreach (AddressComponent addressComponent in result.address_components)
                        {
                            if (addressComponent.types.Contains("administrative_area_level_1"))
                            {
                                state = addressComponent.long_name;
                            }
                        }
                    }
                }
                else
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = data.status; 
                }                
            }
            catch (JsonReaderException jex)
            {                
                ErrorLabel.Text = jex.Message;
            }
            return state;
        } 

        protected void SearchStateByCity(object sender, EventArgs e)
        {
            GetCities();
        }
    }
}