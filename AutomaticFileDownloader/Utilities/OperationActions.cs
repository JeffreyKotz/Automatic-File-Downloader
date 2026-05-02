using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{
    public record OperationActions(Action? OperationStarted, Action? OperationCancelled, Action? OperationCompleted, Action? OperationFailed, Action? OperationClear);
}
