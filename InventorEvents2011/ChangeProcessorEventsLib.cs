using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class ChangeProcessorEventsLib : IChangeProcessorEventsLib
    {
        public ChangeProcessorEventsLib(ChangeDefinition changeDefinition)
        {
            ChangeProcessor = changeDefinition.CreateChangeProcessor();
            Activate();
        }

        #region IChangeProcessorEventsLib Members

        public ChangeProcessorSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }
        public ChangeProcessorSink_OnReadFromScriptEventHandler OnReadFromScriptDelegate { get; set; }
        public ChangeProcessorSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }
        public ChangeProcessorSink_OnWriteToScriptEventHandler OnWriteToScriptDelegate { get; set; }

        public ChangeProcessor ChangeProcessor { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            ChangeProcessor.OnExecute -= OnExecuteDelegate;
            OnExecuteDelegate = null;

            ChangeProcessor.OnReadFromScript -= OnReadFromScriptDelegate;
            OnReadFromScriptDelegate = null;

            ChangeProcessor.OnTerminate -= OnTerminateDelegate;
            OnTerminateDelegate = null;

            ChangeProcessor.OnWriteToScript -= OnWriteToScriptDelegate;
            OnWriteToScriptDelegate = null;
        }

        #endregion

        private void Activate()
        {
            ChangeProcessor.OnExecute += OnExecuteDelegate;

            ChangeProcessor.OnReadFromScript += OnReadFromScriptDelegate;

            ChangeProcessor.OnTerminate += OnTerminateDelegate;

            ChangeProcessor.OnWriteToScript += OnWriteToScriptDelegate;
        }
    }
}