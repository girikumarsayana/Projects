using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetCityAndCapitalByState
{
    public class Locations
    {
        public Response RestResponse { get; set; }
    }
    public class Location
    {
        public int id { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string abbr { get; set; }
        public string area { get; set; }
        public string largest_city { get; set; }
        public string capital { get; set; }
    }

    public class Response
    {
        public List<string> messages { get; set; }
        public List<Location> result { get; set; }
    }
}