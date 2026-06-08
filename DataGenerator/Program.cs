using System.Data;
using System.Net.Sockets;

namespace DataGenerator
{
    internal class Program
    {
       
        static async Task Main(string[] args)
        {
            string personsMockData = "https://6a208453e96c1d13b58788cd.mockapi.io/persons";
            string currenciesMockData = "https://coinbase.com/api/v2/currencies";

            using var mockDataService = new MockDataService();
            
            Console.WriteLine("Enter the API URL:");
            string? inputApiUrl = Convert.ToString(Console.ReadLine());
            await mockDataService.SendRequest(inputApiUrl);
            
            Console.WriteLine("program ended");
            Console.ReadKey();
        }
        // H:\Udemy\.NetPractice\DataGenerator\DataGenerator\DataGenerator.csproj
        // H:\Udemy\.NetPractice\DataGenerator
       
    }
}
