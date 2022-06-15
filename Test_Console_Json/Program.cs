using Test_Console_Json;
string eingabe = "";
Console.WriteLine("Test Console");
Console.WriteLine("Enter Number for REST Call");
Console.WriteLine("1 - 1. API");
eingabe = Console.ReadLine();

if (eingabe == "1")
{
    getTestData g = new getTestData("http://192.168.100.61/Test/MOCK_DATA.json");
}
else if (eingabe == "2")
{
    CommentsApi c = new CommentsApi("https://jsonplaceholder.typicode.com/comments");
}


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









