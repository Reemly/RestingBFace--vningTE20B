using RestSharp;
using System.Text.Json;




RestClient DigimonClient = new RestClient("https://digimon-api.vercel.app/api/digimon");

RestRequest request = new RestRequest("name/kuwagamon");

RestResponse response = DigimonClient.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<List<Digimon>>(response.Content).First();

File.WriteAllText("Digimon.json", d.Level);

Console.WriteLine(d.Level);

 Console.ReadLine();
 


