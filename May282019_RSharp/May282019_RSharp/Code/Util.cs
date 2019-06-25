//
/*
 * 
        //Instead of using RestSharp use Native C# HTTPWebRequest Support
        //System.Net.HttpWebRequest request2 = new System.Net.HttpWebRequest();
        //request2.Method = "POST";



        //Validator of Deserialized Item
        Person personDeserialized = (Person)Deserialize(typeof(Person), jsonString);
        if ((person.email.Equals(personDeserialized.email)) &&
            (person.employeeID == personDeserialized.employeeID) &&
            (person.firstName.Equals(personDeserialized.firstName)) &&
            (person.lastName.Equals(personDeserialized.lastName)) &&
            (person.phone.Equals(personDeserialized.phone)))
        {
            Console.WriteLine("Successfully deserialized object.");
        }

        */

using System;
using System.Text;

namespace May282019_RSharp.Code
{
    public class Util
    {
       
        // 
        public static String genRandomString(int charCount)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            char ch;
            for(int i = 0; i < charCount; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        //Native Serializer in C# .Net  
        public static string Serialize(object obj)
        {

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            Type type = obj.GetType();
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(type);
            serializer.WriteObject(memoryStream, obj);

            memoryStream.Position = 0;
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            string jsonString = streamReader.ReadToEnd();
            streamReader.Close();
            memoryStream.Close();

            return jsonString;

        }

        //Native Deserializer in C# .Net
        public static object Deserialize(Type type, string jsonString)
        {

            System.Runtime.Serialization.Json.DataContractJsonSerializer deserializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(type);
            byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
            System.IO.MemoryStream memoryStreamDeserializer = new System.IO.MemoryStream(jsonBytes);
            object obj = deserializer.ReadObject(memoryStreamDeserializer);
            return obj;
        }
    }
}
