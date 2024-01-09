using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fstb.WebTest.StepDefinitions
{
    [Binding]
    public class AuthenticationSteps
    {
        private HttpClient _client;
        private HttpResponseMessage _response;
        private StringContent _stringContent;

        [Given(@"I have a valid user credential")]
        public void GivenIHaveAValidUserCredential()
        {
            _client = new HttpClient();

            _stringContent = new StringContent(
                JsonConvert.SerializeObject(new
                {
                    userName = "",
                    password = "",
                    deviceId = "",
                    env = 0
                }),
                null,
                "application/json"
            );
        }

        [When(@"I send a POST request to '(.*)'")]
        public void WhenISendAPOSTRequestTo(string url)
        {
            _response = _client.PostAsync(url, _stringContent).Result;
        }

        [Then(@"the response should be OK")]
        public void ThenTheResponseShouldBe()
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
        }
    }
}
