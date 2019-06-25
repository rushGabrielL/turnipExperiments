using System;
using System.Runtime.Serialization;
using RestSharp;
using May282019_RSharp.Code;


namespace May282019_RSharp
{

    class main
    {
        public static string baseUrl = "http://127.0.0.1:8080";
        public static string URL = "api/tutorial/1.0/employees";

        static void Main(String[] args)
        {


            //getFunction(82);


            for(int i = 0; i <= 5; i++)
            {
                postFunction();
            }


            //deleteFunction(86);

        }


        public static void getFunction()
        {

            var client = new RestClient(baseUrl);
            var request = new RestRequest("api/tutorial/1.0/employees", Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            if(content == "")
            {
                Console.Write("Null Response");
            }
            else
            {
                Console.WriteLine(content);
            }
        }

        public static void getFunction(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("api/tutorial/1.0/employees/{id}", Method.GET);
            request.AddUrlSegment("id", id);

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            if (content == "")
            {
                Console.Write("Null Response");
            }
            else
            {
                Console.WriteLine(content);
            }
        }


        public static void postFunction()
        {
            DataBank.Person person = new DataBank.Person();

            String suffix = Util.genRandomString(5);
            int randomID = new Random().Next(1,100);

            person.employeeId= randomID;
            person.firstName = "Test01-" + suffix;
            person.lastName = "Test01-" + suffix;
            person.email = "test01-" + suffix + "@mailinator.com";
            person.phone = "5123213";

            string jsonString = Util.Serialize(person);
            Console.WriteLine(jsonString);

            var client = new RestClient("http://127.0.0.1:8080");
            var request = new RestRequest("api/tutorial/1.0/employees", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept","*/*");
            request.AddJsonBody(jsonString);

            client.Execute(request);


        }

        public static void deleteFunction(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("api/tutorial/1.0/employees/{id}", Method.DELETE);
            request.AddUrlSegment("id", id.ToString());

            Console.WriteLine("Sending Request");
            IRestResponse response = client.Execute(request);
            Console.WriteLine("Retrieving Response");
            var content = response.StatusCode + "     " + response.Content + response.ResponseUri;
            Console.WriteLine(content);

        }

    }
}
