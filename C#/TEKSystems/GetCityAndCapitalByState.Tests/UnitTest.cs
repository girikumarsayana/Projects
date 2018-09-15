using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetCityAndCapitalByState.Tests
{
    [TestClass]
    public class UnitTest
    {
        WebServiceResponse webResponse = new WebServiceResponse();
        Home GetCityAndCapital = new Home();
        string url = Home.resourcePath;

        [TestMethod]
        public void TestWebServiceIsNotNull()
        {

            var response = webResponse.GetResponse(url);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetLargestCityTest()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string largestCity = GetCityAndCapital.GetLargestCity("Alabama", response);

            Assert.AreEqual(largestCity, "Birmingham");
        }
        [TestMethod]
        public void GetLargestcityNotValidData()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string largestCity = GetCityAndCapital.GetLargestCity("abcahfl", response);

            Assert.AreEqual(largestCity, "");
        }
        [TestMethod]
        public void GetLargestcityEmptySearch()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string largestCity = GetCityAndCapital.GetLargestCity("", response);

            Assert.AreEqual(largestCity, "");
        }

        [TestMethod]
        public void GetCapitalTest()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string Capital = GetCityAndCapital.GetCapital("Arizona", response);

            Assert.AreEqual(Capital, "Phoenix");
        }
        [TestMethod]
        public void GetCapitalNotValidData()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string Capital = GetCityAndCapital.GetCapital("abcahfl", response);

            Assert.AreEqual(Capital, "");
        }
        [TestMethod]
        public void GetCapitalEmptySearch()
        {
            Response response = GetCityAndCapital.GetWebResponseData();
            string Capital = GetCityAndCapital.GetCapital("", response);

            Assert.AreEqual(Capital, "");
        }
    }
}
