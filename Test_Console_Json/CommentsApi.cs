using Newtonsoft.Json;
using RestSharp;

namespace Test_Console_Json
{
    public partial class CommentsApi
    {
        string GetReleases(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute(new RestRequest());
            return response.Content;
        }

        public CommentsApi(string url)
        {
            List<Root> account = JsonConvert.DeserializeObject<List<Root>>(GetReleases(url));
            Console.WriteLine("Comments \n");
            foreach (var item in account)
            {
                Console.WriteLine("E-Mail: " + item.email);
                Console.WriteLine("Message: " + item.body);
                Console.WriteLine("\n");
            }
        }

    }

    public partial class getTestData
    {
        string GetReleases(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute(new RestRequest());
            return response.Content;
        }

        public getTestData(string url)
        {
            List<Root_> account = JsonConvert.DeserializeObject<List<Root_>>(GetReleases(url));
            Console.WriteLine("TEST \n");
            foreach (var item in account)
            {
                Console.WriteLine("id: " + item.id);
                Console.WriteLine("first_name: " + item.first_name);
                Console.WriteLine("last_name: " + item.last_name);
                Console.WriteLine("ip_address: " + item.ip_address);
                Console.WriteLine("gender: " + item.gender);

                Console.WriteLine("\n");
            }
        }

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }

    public class Root_
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string ip_address { get; set; }
    }

}
