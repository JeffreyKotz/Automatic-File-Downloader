namespace AutomaticFileDownloader.Utilities.Handlers
{
    public record OperationEvents(
        EventHandler OperationStarted,
        EventHandler OperationCancelled,
        EventHandler OperationCompleted,
        EventHandler OperationFailed,
        EventHandler OperationClear
    );
}