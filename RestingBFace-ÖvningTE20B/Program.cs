using RestSharp;
using System.Text.Json;




RestClient DigimonClient = new RestClient("https://digimon-api.vercel.app/api/digimon");

RestRequest request = new RestRequest("name/kuwagamon");

RestResponse response = DigimonClient.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<List<Digimon>>(response.Content).First();


d.Level = "idiot";

string dString = JsonSerializer.Serialize<Digimon>(d);

File.WriteAllText("Digimon.json", dString);

Console.WriteLine(d.Level);

 Console.ReadLine();
 


