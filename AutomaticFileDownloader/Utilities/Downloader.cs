using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{
    internal static class Downloader
    {
        private static readonly HttpClient _client = new HttpClient();
        private static CancellationTokenSource _s_cts = new CancellationTokenSource();
        private static CancellationToken _cancellationToken = _s_cts.Token;

        public static async Task DownloadFileAsync(string url, string targetFilePath)
        {
            // Add headers to prevent 403 response
            if (!_client.DefaultRequestHeaders.Contains("User-Agent"))
            {
                _client.DefaultRequestHeaders.Add(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 "
                    + "(KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36"
                    );
            }

            // Send GET request asynchronously with cancellation support
            using HttpResponseMessage response = await _client.GetAsync(
                url,
                HttpCompletionOption.ResponseHeadersRead,
                _cancellationToken
            );

            response.EnsureSuccessStatusCode();

            // Open stream to write to file
            using var writeFileStream = new FileStream(
                    targetFilePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None
            );

            // Open stream from web content for reading
            using var readStream = await response.Content.ReadAsStreamAsync(_cancellationToken);

            // Wait copy read data to file
            await readStream.CopyToAsync(writeFileStream, 81920, _cancellationToken);
            
        }

        public static async Task Cancel()
        {
            _s_cts.Cancel();

            // Make new cancellation token source to continue downloads
            _s_cts.Dispose();
            _s_cts = new CancellationTokenSource();
            _cancellationToken = _s_cts.Token;
        }
    }
}
