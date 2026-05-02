using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static System.Windows.Forms.Design.AxImporter;

namespace AutomaticFileDownloader.Utilities
{

    /// <summary>
    /// This class solely exists to manage the different states of the download process
    /// I felt that should be the responsibility of a seperate class rather than the form or the downloader itself
    /// </summary>
    internal class DownloadHandler : OperationHandler
    {
        protected override async Task ProcessOperation(OperationEvents events, OperationArguments args)
        {
            try
            {
                await Downloader.DownloadFileAsync(args);
                events.OperationCompleted?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // Can't cancel what you already finished :P
            }
            catch (OperationCanceledException) { } // no op, other method already handles cancellation logic
            catch (HttpRequestException ex) // Issue with request
            {
                events.OperationFailed?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // can't cancel when it fails
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex) // Issue with file operations
            {
                events.OperationFailed?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // can't cancel when it fails
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) // Catch all other exceptions
            {
                events.OperationFailed?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // can't cancel when it fails
                MessageBox.Show(ex.Message);
            }
        }
    }
}
