namespace AutomaticFileDownloader.Utilities.Handlers
{
    /// <summary>
    /// Handler for download operations.
    ///
    /// This was very weird with generic templates, I I didn't expect that I could specify the generic type
    /// when deriving for the download handler.
    /// </summary>
    internal class DownloadHandler : OperationHandler<DownloadArguments>
    {

        /// <summary>
        /// Process the download operation
        /// </summary>
        /// <param name="events"> events for the specfic operation </param>
        /// <param name="args"> arguments for the operation </param>
        /// <returns></returns>
        protected override async Task ProcessOperation(OperationEvents events, DownloadArguments args)
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
                MessageBox.Show(ex.Message); // show error
            }
            catch (IOException ex) // Issue with file operations
            {
                events.OperationFailed?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // can't cancel when it fails
                MessageBox.Show(ex.Message); // show error
            }
            catch (Exception ex) // Catch all other exceptions
            {
                events.OperationFailed?.Invoke(this, EventArgs.Empty);
                OperationCancelled -= events.OperationCancelled; // can't cancel when it fails
                MessageBox.Show(ex.Message); // show error
            }
        }

        protected override void CancelProcessOperation()
        {
            Downloader.Cancel();
        }
    }
}