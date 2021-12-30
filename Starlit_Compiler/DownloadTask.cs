using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace Starlit_Compiler
{
    class DownloadTask
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public long BytesReceived { get; private set; } = 0;
        public bool Completed { get; private set; } = false;
        public event Action DownloadCompleted;
        public Task Task { get; }

        public DownloadTask(string url, string filePath)
        {
            Task = DownloadFileAsync(url, filePath);
        }

        private async Task DownloadFileAsync(string url, string filePath)
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var dataStream = await response.Content.ReadAsStreamAsync();
            BytesReceived = dataStream.Length;
            using (FileStream fileStream = File.Create(filePath))
            {
                await dataStream.CopyToAsync(fileStream);
            }
            Completed = true;
            DownloadCompleted?.Invoke();
        }

        public static Task<string> GetStringAsync(string url) => httpClient.GetStringAsync(url);
    }
}
