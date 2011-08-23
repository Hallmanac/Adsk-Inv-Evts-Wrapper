using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IChangeProcessorEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.ChangeProcessor object
        /// </summary>
        ChangeProcessor ChangeProcessor { get; }

        #region Event Handler Delegates
        ChangeProcessorSink_OnExecuteEventHandler OnExecuteDelegate { get; set; }
        ChangeProcessorSink_OnReadFromScriptEventHandler OnReadFromScriptDelegate { get; set; }
        ChangeProcessorSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }
        ChangeProcessorSink_OnWriteToScriptEventHandler OnWriteToScriptDelegate { get; set; }
        #endregion
        

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
