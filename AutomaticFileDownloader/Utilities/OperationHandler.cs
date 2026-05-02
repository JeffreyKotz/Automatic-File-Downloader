using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticFileDownloader.Utilities
{
    internal abstract class OperationHandler
    {
        protected event EventHandler Start;
        protected event EventHandler Cancel;
        protected event EventHandler Clear;
        protected event EventHandler Operation;

        public void QueueOperation(OperationActions actions, OperationArguments args)
        {
            Start += (sender, eventArgs) => { actions.OperationStarted};
            Cancel += (sender, eventArgs) => { actions.OperationCancelled };
            Clear += (sender, eventArgs) => { actions.OperationClear };

            Operation += (sender, eventArgs) => AddOperation(actions, args);
        }

        /// <summary>
        /// These access modifiers  :)
        /// </summary>
        /// <param name="args"></param>
        protected abstract void AddOperation(OperationActions actions, OperationArguments args);
    }
}
