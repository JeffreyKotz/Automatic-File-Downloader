using AutomaticFileDownloader.Utilities.Handlers;
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

        /// <summary>
        /// Download a file according to the given arguments.
        /// </summary>
        /// <param name="args">arguments for download operation, path and url.</param>
        /// <returns></returns>
        public static async Task DownloadFileAsync(DownloadArguments args)
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
                args.URL,
                HttpCompletionOption.ResponseHeadersRead,
                _cancellationToken
            );

            response.EnsureSuccessStatusCode();

            // Open stream to write to file
            using var writeFileStream = new FileStream(
                    args.TargetFilePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None
            );

            // Open stream from web content for reading
            using var readStream = await response.Content.ReadAsStreamAsync(_cancellationToken);

            // Wait copy read data to file
            await readStream.CopyToAsync(writeFileStream, 81920, _cancellationToken);
            
        }

        /// <summary>
        /// Cancel the operation and create a new token source in the event the operation is restarted
        /// </summary>
        public static void Cancel()
        {
            _s_cts.Cancel();

            // Make new cancellation token source to continue downloads
            _s_cts.Dispose();
            _s_cts = new CancellationTokenSource();
            _cancellationToken = _s_cts.Token;
        }

        /// <summary>
        /// Helper function to determine whether or not a given link is valid
        /// </summary>
        /// <param name="link"> Web Link Address to download from</param>
        /// <returns></returns>
        public static bool ValidLink(string link)
        {
            if (link == null || link.Length <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Helper method to check if file path given is valid
        /// </summary>
        /// <param name="path">Path to check</param>
        /// <returns></returns>
        public static bool ValidFilePath(string path)
        {
            if (path == null || path.Length <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
