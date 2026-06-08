using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator
{
    public class MockDataService : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool _disposed = false; 
        public MockDataService()
        {
            _httpClient = new HttpClient();
        }

        ~MockDataService()
        {
            // This finalizer will only be called if the consumer of this class forgets to call Dispose(),
            // which is a safety net to ensure resources are released. However, since HttpClient implements IDisposable,
            // it's best practice to dispose of it explicitly in the Dispose method.
            Dispose(false);
        }

        private protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Dispose of managed resources here. In this case, we have the HttpClient instance to dispose of.
                _httpClient.Dispose();
            }
            // Dispose of unmanaged resources here, if any. In this case, we don't have any unmanaged resources to clean up.
            // Mark the object as disposed to prevent multiple disposals.
            

            _disposed = true; 

        }
        public void Dispose()
        {
            // 100% of the time, this method will be called by the consumer of this class,
            // so we can safely dispose of the HttpClient instance here.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SendRequest(string resourceUrl)
        {
            string data = await GetData(resourceUrl);
            Console.WriteLine(data);
        }
        private async Task<string> GetData(string resourceUrl)
        {
            string response = string.Empty; 
            try
            {
                response = await _httpClient.GetStringAsync(resourceUrl);
                Console.WriteLine("Enter the file name:");
                string? fileName = Console.ReadLine();
                await StoreDataIntoFile(response, $"H:\\Udemy\\.NetPractice\\DataGenerator\\DataGenerator\\{fileName}.json");
            }
            catch
            {
                Console.WriteLine("Failed to get data from the API. Ensure the URL is correct and the API is accessible.");
            }
            return response;
        }

        private async Task StoreDataIntoFile(string data, string filePath, string fileName = "data.json")
        {
            await File.WriteAllTextAsync(filePath, data);
        }

        
    }
}
