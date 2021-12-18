using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Net;

namespace Starlit_Compiler
{
    class DownloadTask : IDisposable
    {
        public long BytesReceived { get; private set; } = 0;
        public long TotalBytes { get; private set; } = 0;
        public bool Completed { get; private set; } = false;
        public event Action ProgressChanged;
        private readonly WebClient webClient;
        public Task Task { get; }

        public DownloadTask(string url, string filePath)
        {
            webClient = new WebClient();
            webClient.DownloadProgressChanged += ClientDownloadProgressChanged;
            webClient.DownloadFileCompleted += ClientDownloadFileCompleted;
            Task = webClient.DownloadFileTaskAsync(url, filePath);
        }

        private void ClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            BytesReceived = e.BytesReceived;
            TotalBytes = e.TotalBytesToReceive;
            ProgressChanged?.Invoke();
        }
        private void ClientDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Completed = true;
            ProgressChanged?.Invoke();
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                webClient.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
    }
}
