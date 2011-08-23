using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class ChangeProcessorEventsLib : IChangeProcessorEventsLib
    {
        public ChangeProcessorSink_OnExecuteEventHandler OnExecuteDelegate
        { get; set; }
        public ChangeProcessorSink_OnReadFromScriptEventHandler OnReadFromScriptDelegate
        { get; set; }
        public ChangeProcessorSink_OnTerminateEventHandler OnTerminateDelegate
        { get; set; }
        public ChangeProcessorSink_OnWriteToScriptEventHandler OnWriteToScriptDelegate
        { get; set; }

        public ChangeProcessor ChangeProcessor { get; private set; }

        public ChangeProcessorEventsLib(ChangeDefinition changeDefinition)
        {
            this.ChangeProcessor = changeDefinition.CreateChangeProcessor();
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ChangeProcessor.OnExecute -= this.OnExecuteDelegate;
            this.OnExecuteDelegate = null;

            this.ChangeProcessor.OnReadFromScript -= this.OnReadFromScriptDelegate;
            this.OnReadFromScriptDelegate = null;

            this.ChangeProcessor.OnTerminate -= this.OnTerminateDelegate;
            this.OnTerminateDelegate = null;

            this.ChangeProcessor.OnWriteToScript -= this.OnWriteToScriptDelegate;
            this.OnWriteToScriptDelegate = null;
        }
    }
}
