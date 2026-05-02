using System;
using System.Collections.Generic;
using System.Text;

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
