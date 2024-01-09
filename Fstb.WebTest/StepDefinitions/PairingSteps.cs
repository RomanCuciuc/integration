using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fstb.WebTest.StepDefinitions
{
    [Binding]
    public class PairingSteps
    {
        private HttpClient _client;
        private HttpResponseMessage _response;

        [Given(@"I have valid userId and devieId")]
        public void GivenIHaveAValidUserCredential()
        {
            _client = new HttpClient();
        }

        [When(@"I send GET request to '(.*)'")]
        public void WhenISendAGetRequestTo(string url)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");
            _response = _client.GetAsync(url).Result;
        }

        [Then(@"I'm getting response 1")]
        public void ThenTheResponseShouldBe()
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
        }
    }
}
