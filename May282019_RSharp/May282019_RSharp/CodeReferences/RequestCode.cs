using System;
using RestSharp;

namespace May282019_RSharp.CodeReferences
{
    public class RequestCode
    {
        /*
        public RequestCode()
        {
            public static IRestResponse GETrequest(string baseURL, string endpoint, string userToken)
            {
                var client = new RestClient(baseURL);
                var request = new RestRequest(endpoint);
                request.AddHeader("Authorization", userToken);

                var response = client.Execute(request);
                Console.WriteLine((int)response.StatusCode);
                return response;
            }

            public static IRestResponse POSTrequest(string baseURL, string endpoint, string userToken, object jsonParameter)
            {
                var client = new RestClient(baseURL);
                var request = new RestRequest(endpoint, Method.POST);
                request.AddHeader("Authorization", userToken);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(jsonParameter);

                var response = client.Execute(request);
                Console.WriteLine((int)response.StatusCode);
                return response;
            }

            public static IRestResponse PUTrequest(string baseURL, string endpoint, string userToken, object jsonParameter)
            {
                var client = new RestClient(baseURL);
                var request = new RestRequest(endpoint, Method.PUT);
                request.AddHeader("Authorization", userToken);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(jsonParameter);

                var response = client.Execute(request);
                Console.WriteLine((int)response.StatusCode);
                return response;
            }

            public static IRestResponse DELETErequest(string baseURL, string endpoint, string userToken)
            {
                var client = new RestClient(baseURL);
                var request = new RestRequest(endpoint, Method.DELETE);
                request.AddHeader("Authorization", userToken);

                var response = client.Execute(request);
                Console.WriteLine((int)response.StatusCode);
                return response;
            }
        }
            */
    }

}
