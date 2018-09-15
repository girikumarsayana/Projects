using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetCityAndCapitalByState
{
    public partial class Home : System.Web.UI.Page
    {

        public static string resourcePath = "http://services.groupkt.com/state/get/USA/all";
        WebServiceResponse webResponse = new WebServiceResponse();
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            ErrorlabelCapital.Visible = false;
            ErrorlabelCity.Visible = false;
        }

        protected void SearchByState(object sender, EventArgs e)
        {
            ShowlargestCityAndCapital();
        }
        private void ShowlargestCityAndCapital()
        {
            //ensuring whether the country Name is not empty  
            if (SearchField.Text == "" || SearchField.Text == null)
            {
                ErrorLabel.Text = "Please Enter State Name or Abbr";
                largestCityTextBox.Text = "";
                CapitalTextBox.Text = "";
                ErrorLabel.Visible = true;
            }
            else
            {
                Response response = GetWebResponseData();
                string largest_City = GetLargestCity(SearchField.Text.Trim(), response);
                if (largest_City != "" && largest_City != null)
                {
                    largestCityTextBox.Text = largest_City;
                }
                else
                {
                    ErrorlabelCity.Text = "There is no data for " + SearchField.Text.Trim() + " State";
                    largestCityTextBox.Text = "";
                    ErrorlabelCity.Visible = true;
                }

                string capital = GetCapital(SearchField.Text.Trim(), response);

                if (capital != "" && capital != null)
                {
                    CapitalTextBox.Text = capital;
                }
                else
                {
                    ErrorlabelCapital.Text = "There is no data for " + SearchField.Text.Trim() + " State";
                    CapitalTextBox.Text = "";
                    ErrorlabelCapital.Visible = true;
                }
            }
        }

        public Response GetWebResponseData()
        {
            string responseFromServer = webResponse.GetResponse(resourcePath);
            try
            {
                Locations data = JsonConvert.DeserializeObject<Locations>(responseFromServer);
                if (data.RestResponse.result.Count >= 0)
                {
                    return data.RestResponse;
                }
            }
            catch (JsonReaderException jex)
            {
                //ErrorLabel.Text = jex.Message;
                //ErrorLabel.Visible = true;
            }
            return null;
        }

        public string GetLargestCity(string stateName, Response response)
        {
            string largest_City = "";
            if (response != null)
            {
                foreach (Location location in response.result)
                {
                    if (location.abbr.Equals(stateName, StringComparison.InvariantCultureIgnoreCase) || location.name.Equals(stateName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        largest_City = location.largest_city;
                        break;
                    }
                }
            }
            return largest_City;
        }

        public string GetCapital(string stateName, Response response)
        {
            string capital = "";
            if (response != null)
            {
                foreach (Location location in response.result)
                {
                    if (location.abbr.Equals(stateName, StringComparison.InvariantCultureIgnoreCase) || location.name.Equals(stateName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        capital = location.capital;
                        break;
                    }
                }
            }
            return capital;
        }

    }
}