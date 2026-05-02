using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{

    /// <summary>
    /// This class solely exists to manage the different states of the download process
    /// I felt that should be the responsibility of a seperate class rather than the form or the downloader itself
    /// </summary>
    internal static class DownloadHandler
    {
        private static Action? _download;
        private static Action? _cancel;
        private static Action? _dispose;

        public static void AddDownload(string url, string targetFilePath, OperationActions actions)
        {
            _cancel += actions.OperationCancelled;
            _dispose += actions.OperationClear;
            _download += async () =>
            {
                try
                {
                    actions.OperationStarted?.Invoke();
                    await Downloader.DownloadFileAsync(url, targetFilePath);
                    actions.OperationCompleted?.Invoke();
                    _cancel -= actions.OperationCancelled; // Can't cancel what you already finished :P
                }
                catch (OperationCanceledException) {} // no op, other method already handles cancellation logic
                catch (HttpRequestException ex) // Issue with request
                {
                    actions.OperationFailed?.Invoke();
                    _cancel -= actions.OperationCancelled; // can't cancel when it fails
                    MessageBox.Show(ex.Message);
                }
                catch (IOException ex) // Issue with file operations
                {
                    actions.OperationFailed?.Invoke();
                    _cancel -= actions.OperationCancelled; // can't cancel when it fails
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex) // Catch all other exceptions
                {
                    actions.OperationFailed?.Invoke();
                    _cancel -= actions.OperationCancelled; // can't cancel when it fails
                    MessageBox.Show(ex.Message);
                }
            };
        }

        public static void StartDownload()
        {
            _download?.Invoke();
            _download = null; // clear queued downloads to prevent duplicate runs on accident
        }

        public static async Task CancelDownload()
        {
            // Cancel The operation
            await Downloader.Cancel();


            _cancel?.Invoke();
            _download = null;  // Remove any queued downloads
            _cancel = null; // can't cancel multiple times
        }

        public static void Dispose()
        {
            _dispose?.Invoke();
            _download = null;
            _cancel = null;
            _dispose = null;
        }
    }
}
