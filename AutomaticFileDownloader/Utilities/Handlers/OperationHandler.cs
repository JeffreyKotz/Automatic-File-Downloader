namespace AutomaticFileDownloader.Utilities.Handlers
{
    /// <summary>
    /// A generic operation handler class, handles a generic operation that isn't implemented yet
    /// </summary>
    /// <typeparam name="TArgs"> Generic Type of Arguments given. Took some inspiration from event arguments. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics#type-constraints </typeparam>
    internal abstract class OperationHandler<TArgs> where TArgs : OperationArguments // limit TArgs to only OperationArguments
    {
        // Define events, iniitally all other events (complete, failed) were also defined here, but I realized that they need to be seperate
        // so that when one operation is completed, all other operations don't appear to be erroneously completed as well
        protected event EventHandler? OperationStarted;

        protected event EventHandler? OperationCancelled;

        protected event EventHandler? OperationCleared;

        protected Action? Operation;

        /// <summary>
        /// Queue an operation for processing
        /// </summary>
        /// <param name="events"> events to handle differnt stages/outcomes of the operation </param>
        /// <param name="args"> arguments for the operation </param>
        public void QueueOperation(OperationEvents events, TArgs args)
        {
            OperationStarted += events.OperationStarted;
            OperationCancelled += events.OperationCancelled;
            OperationCleared += events.OperationClear;

            // Queue the actual operation
            Operation += async () =>
            {
                await ProcessOperation(events, args);
            };
        }

        /// <summary>
        /// Start the handeled operation
        /// </summary>
        public void Start()
        {
            OnOperationStarted();
        }

        /// <summary>
        /// Cancel the running operation
        /// </summary>
        public void Cancel()
        {
            OnOperationCancelled();
        }

        /// <summary>
        /// Clear all operations
        /// </summary>
        public void Clear()
        {
            OnOperationCleared();
        }

        /// <summary>
        /// Invoke the OperationStarted Events and clear the events
        /// </summary>
        protected void OnOperationStarted()
        {
            OperationStarted?.Invoke(this, EventArgs.Empty);
            Operation?.Invoke(); // start the actual operation
            Operation = null; // clear operation so it doesn't start twice
            OperationStarted = null; // can't start twice
        }

        /// <summary>
        /// Invoke the Cancelled Event and clean up the cancelled/started events to prevent further operation
        /// </summary>
        protected void OnOperationCancelled()
        {
            CancelProcessOperation();
            OperationCancelled?.Invoke(this, EventArgs.Empty);
            Operation = null; // clear operation so it doesn't start
            OperationCancelled = null; // can't cancel twice
            OperationStarted = null; // can't start what has been cancelled
        }

        /// <summary>
        /// Clear all operations and their related events to ensure no further operation is performed
        /// </summary>
        protected void OnOperationCleared()
        {
            Cancel(); // Cancel any inprogress operations
            OperationCleared?.Invoke(this, EventArgs.Empty);
            OperationCleared = null; // Can't clear twice as well :)
        }

        /// <summary>
        /// the actual operation being performed. Implemented by derived classes.
        /// </summary>
        /// <param name="events"> events related to operation necessary for providing updates of individual operation </param>
        /// <param name="args"> arguments for operation </param>
        /// <returns></returns>
        protected abstract Task ProcessOperation(OperationEvents events, TArgs args);

        /// <summary>
        /// Cancellation of the performed operation, handled by derived classes.
        /// </summary>
        /// <returns></returns>
        protected abstract void CancelProcessOperation();
    }
}