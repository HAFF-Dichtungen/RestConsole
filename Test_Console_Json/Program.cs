//using Newtonsoft.Json;
//using RestSharp;

//string GetReleases(string url)
//{
//    var client = new RestClient(url);
//    var response = client.Execute(new RestRequest());
//    return response.Content;
//}
//try
//{
//    List<Person.RootObject> account = JsonConvert.DeserializeObject<List<Person.RootObject>>(GetReleases("https://jsonplaceholder.typicode.com/users"));
//   // List<Account> company = JsonConvert.DeserializeObject<List<Company>>(GetReleases("https://jsonplaceholder.typicode.com/users"));


//    foreach (var item in account)
//    {

//        //Console.WriteLine(item.username + "\n" + item.name + "\n" + item.email + "\n");
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}


//public class Person
//{
//    public class Account
//    {
//        public string name { get; set; }
//        public string username { get; set; }
//        public string email { get; set; }
//       // public string Company { get; set; }

//        public Company Company { get; set; }
//        //public Array company { get; set; }
//    }
//    public class Company
//    {
//        public string name { get; set; }

//        //public Array company { get; set; }
//    }
//    public class RootObject 
//    { 
//    public Account Account { get; set; }
//    }

//}

//using Newtonsoft.Json;
//using RestSharp;

//string GetReleases(string url)
//{
//    var client = new RestClient(url);
//    var response = client.Execute(new RestRequest());
//    return response.Content;
//}

//try
//{
//    List<Root> account = JsonConvert.DeserializeObject<List<Root>>(GetReleases("https://jsonplaceholder.typicode.com/users"));
//    foreach (var item in account)
//    {
//        Console.WriteLine("Name: "+item.name);
//        Console.WriteLine("Mail: " + item.email);
//        Console.WriteLine("City: " + item.address.city);
//        Console.WriteLine("Location: " + item.address.geo.lng +" - "+ item.address.geo.lat);
//        Console.WriteLine("Phone: " + item.phone);
//        Console.WriteLine("Company Name: " + item.company.name);
//        Console.WriteLine("Nompany Phrase: " + item.company.catchPhrase);
//        Console.WriteLine("Company Bs: " + item.company.bs);
//        Console.WriteLine("\n");

//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

using Test_Console_Json;

//CommentsApi c = new CommentsApi();
getTestData g = new getTestData();  

//Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(GetReleases("https://jsonplaceholder.typicode.com/users"));
public class Address
{
    public string street { get; set; }
    public string suite { get; set; }
    public string city { get; set; }
    public string zipcode { get; set; }
    public Geo geo { get; set; }
}

public class Company
{
    public string name { get; set; }
    public string catchPhrase { get; set; }
    public string bs { get; set; }
}

public class Geo
{
    public string lat { get; set; }
    public string lng { get; set; }
}

public class Root
{
    public int id { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public Address address { get; set; }
    public string phone { get; set; }
    public string website { get; set; }
    public Company company { get; set; }
}









