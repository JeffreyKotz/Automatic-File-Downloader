using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{
    public record DownloadActions(Action? DownloadStarted, Action? DownloadCancelled, Action? DownloadCompleted, Action? DownloadFailed, Action? DisposeLabel);

    /// <summary>
    /// This class solely exists to manage the different states of the download process
    /// I felt that should be the responsibility of a seperate class rather than the form or the downloader itself
    /// </summary>
    internal static class DownloadHandler
    {
        private static Action? _download;
        private static Action? _cancel;
        private static Action? _dispose;

        public static void AddDownload(string url, string targetFilePath, DownloadActions actions)
        {
            _cancel += actions.DownloadCancelled;
            _dispose += actions.DisposeLabel;
            _download += async () =>
            {
                try
                {
                    actions.DownloadStarted?.Invoke();
                    await Downloader.DownloadFileAsync(url, targetFilePath);
                    actions.DownloadCompleted?.Invoke();
                    _cancel -= actions.DownloadCancelled; // Can't cancel what you already finished :P
                }
                catch (OperationCanceledException) {} // no op, other method already handles cancellation logic
                catch (Exception ex)
                {
                    actions.DownloadFailed?.Invoke();
                    _cancel -= actions.DownloadCancelled; // can't cancell when it fails
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

        public static bool ValidLink(string link)
        {
            if (link == null || link.Length <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool ValidFilePath(string path)
        {
            if (path == null || path.Length <= 0) {
                return false;
            }

            return true;
        }
    }
}
